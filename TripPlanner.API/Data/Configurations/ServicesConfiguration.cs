using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TripPlanner.API.Data.Configurations
{
    public class ServicesConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder) {
            builder.HasData(
                new Service
                {
                    Id = 1,
                    Name = "ifjas",
                    Address = "somewhere",
                    Description = "good hotel",
                    GovernorateId = 1,
                    ApiUserId= "53efaa18-7ae1-499a-b96c-3e7529c10b42",
                    ServiceTypeId =1,

                }
            );
        
        }
    }
}
