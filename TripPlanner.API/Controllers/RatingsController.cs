using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using TripPlanner.API.Contracts;
using TripPlanner.API.Data;
using TripPlanner.API.Model.Ratings;

namespace TripPlanner.API.Controllers
{
    [ApiController]
    [Route("/api/{serviceId}/Ratings")]
    public class RatingsController(IRatingsRepository ratings, UserManager<ApiUser> userManager, IMapper mapper) : ControllerBase
    {

        [HttpPost]
        [Authorize(Roles = "User")]

        public async Task<ActionResult> CreateRating([FromRoute] int serviceId, CreateRatingsDto createRatingsDto)
        {
            var full_rating = mapper.Map<Ratings>(createRatingsDto);
            var user = await GetCurrentUser();
            var user_id = user.Id.ToString();
            full_rating.ApiUserId = user_id;
            full_rating.ServiceId = serviceId;
            await ratings.AddAsync(full_rating);
             var all_ratings=await ratings.GetAllInServiceAsync(serviceId);
            var rates = all_ratings.ToList();
            await ratings.UpdateRating(serviceId,rates);
            return Ok(full_rating);
        }
        // majd idk how to put more than one role and my battery is dying but put all roles that aren't users
        [HttpGet]
        [Authorize(Roles ="HotelOwner")]
        public async Task<ActionResult<IEnumerable<Ratings>>>GetAllRatingsInService(int serviceId)
        {
            var ratingList = await ratings.GetAllInServiceAsync(serviceId);
            return Ok(ratingList);
        }


        private async Task<ApiUser> GetCurrentUser()
        {
            var user = await userManager.GetUserAsync(HttpContext.User);

            if (user is null)
            {
                return null;
            }
            return user;
        }
    }
}
