using AutomobileRentals.EntityFramework.Models;

namespace AutomobileRentals.EntityFramework.Data.SeedData
{
    public static class DbInitializer
    {
        public static async void Initialize(AppDbContext context)
        {
            if (context.carTypes.Any())
            {
                return;
            }

            var carTypes = new List<CarType>()
            {

                     new CarType
            {
                Id = 1,
                Name = "Sedan",
                Description = "A small to medium-sized car with seating for four or more passengers.",
                ImageUrl = "https://example.com/images/sedan.jpg"
                },
                new CarType
                {
                    Id = 2,
                    Name = "SUV",
                    Description = "A sport utility vehicle with a higher ground clearance, capable of off-road driving.",
                    ImageUrl = "https://example.com/images/suv.jpg"
                },
                new CarType
                {
                    Id = 3,
                    Name = "Hatchback",
                    Description = "A compact car with a rear door that swings upwards, providing more cargo space.",
                    ImageUrl = "https://example.com/images/hatchback.jpg"
                },
                new CarType
                {
                    Id = 4,
                    Name = "Coupe",
                    Description = "A stylish, two-door car often designed for performance and aesthetics.",
                    ImageUrl = "https://example.com/images/coupe.jpg"
                },
                new CarType
                {
                    Id = 5,
                    Name = "Convertible",
                    Description = "A car with a retractable roof, allowing open-air driving.",
                    ImageUrl = "https://example.com/images/convertible.jpg"
                }


        };

            await context.AddRangeAsync(carTypes);
            context.SaveChanges();

        }
    }
}
