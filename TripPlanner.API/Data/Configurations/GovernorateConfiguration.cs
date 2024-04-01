using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TripPlanner.API.Data.Configurations
{
	public class GovernorateConfiguration : IEntityTypeConfiguration<Governorate>
	{
		public void Configure(EntityTypeBuilder<Governorate> builder)
		{
			builder.HasData(
				new Governorate
				{
					Id = 1,
					Name = "Damascus",
					Description = "Damascus is the capital of Syria"
				},
				new Governorate
				{
					Id = 2,
					Name = "Latakia",
					Description = "Latakia is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 3,
					Name = "Tartous",
					Description = "Tartous is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 4,
					Name = "Aleppo",
					Description = "Aleppo is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 5,
					Name = "Daraa",
					Description = "Daraa is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 6,
					Name = "Qunaitira",
					Description = "Qunaitira is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 7,
					Name = "Sweida",
					Description = "Sweida is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 8,
					Name = "Idleb",
					Description = "Idleb is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 9,
					Name = "Deir Al Zor",
					Description = "Deir Al Zor is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 10,
					Name = "Al Hasaka",
					Description = "Al Hasaka is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 11,
					Name = "Qamshli",
					Description = "Qamshli is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 12,
					Name = "Al Raqqa",
					Description = "Al Raqqa is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 13,
					Name = "Hama",
					Description = "Hama is one of the Syrian governorate"
				},
				new Governorate
				{
					Id = 14,
					Name = "Liwaa Iskandaron",
					Description = "Liwaa Iskandaron is one of the Syrian governorate"
				}
			);
		}
	}
}
