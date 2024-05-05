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
    public class RatingsController(IRatingsRepository ratings,UserManager<ApiUser> userManager,IMapper mapper) :ControllerBase
    {

        [HttpPost]
        [Authorize(Roles ="User")]
        
        public async Task<ActionResult> CreateRating([FromRoute]int serviceId,CreateRatingsDto createRatingsDto)
        {
            var full_rating = mapper.Map<Ratings>(createRatingsDto);
            var user =await  GetCurrentUser();
            var user_id = user.Id.ToString();
            full_rating.ApiUserId = user_id;
            full_rating.ServiceId = serviceId;
            await ratings.AddAsync(full_rating);
            return Ok(full_rating);
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
