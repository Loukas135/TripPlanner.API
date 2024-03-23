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
					Name = "Damascus",
					Description = "Damascus is the capital of Syria"
				},
				new Governorate
				{
					Name = "Latakia",
					Description = "Latakia is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Tartous",
					Description = "Tartous is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Aleppo",
					Description = "Aleppo is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Daraa",
					Description = "Daraa is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Qunaitira",
					Description = "Qunaitira is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Sweida",
					Description = "Sweida is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Idleb",
					Description = "Idleb is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Deir Al Zor",
					Description = "Deir Al Zor is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Al Hasaka",
					Description = "Al Hasaka is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Qamshli",
					Description = "Qamshli is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Al Raqqa",
					Description = "Al Raqqa is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Hama",
					Description = "Hama is one of the Syrian governorate"
				},
				new Governorate
				{
					Name = "Liwaa Iskandaron",
					Description = "Liwaa Iskandaron is one of the Syrian governorate"
				}
			);
		}
	}
}
