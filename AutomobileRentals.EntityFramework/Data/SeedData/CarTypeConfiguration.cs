using AutomobileRentals.EntityFramework.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AutomobileRentals.EntityFramework.Data.SeedData
{
    public class CarTypeConfiguration : IEntityTypeConfiguration<CarType>
    {
        public void Configure(EntityTypeBuilder<CarType> builder)
        {
            builder.HasData(
                new CarType
            {
                Id = 1,
                Name = "Sedan",
                Description = "A small to medium-sized car with seating for four or more passengers.",
                ImageUrl = "https://www.carmag.co.za/wp-content/uploads/2023/02/Toyota-Corolla-Quest-1.8-Plus-jpg.webp"
                },
                new CarType
                {
                    Id = 2,
                    Name = "SUV",
                    Description = "A sport utility vehicle with a higher ground clearance, capable of off-road driving.",
                    ImageUrl = "https://robbreport.com/wp-content/uploads/2023/04/12-6.jpg?w=1000"
                },
                new CarType
                {
                    Id = 3,
                    Name = "Hatchback",
                    Description = "A compact car with a rear door that swings upwards, providing more cargo space.",
                    ImageUrl = "https://cfx-wp-images.imgix.net/2022/05/2022-VW-GTI-scaled.jpg?auto=compress%2Cformat&ixlib=php-3.3.1&s=4a679dbe7f94feeacd09f0db2f1de5da"
                },
                new CarType
                {
                    Id = 4,
                    Name = "Coupe",
                    Description = "A stylish, two-door car often designed for performance and aesthetics.",
                    ImageUrl = "https://cdn.jdpower.com/JDPA_2020%20Ford%20Mustang%20Yellow%20Rear%20View.jpg"
                }
               );
        }
    }
}
