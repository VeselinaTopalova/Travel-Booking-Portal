namespace TravelBookingPortal.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using TravelBookingPortal.Data.Models;

    public class DestinationsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Destinations.Any())
            {
                return;
            }

            var destinations = new List<string> { "Africa", "Europe", "Asia", "North America", "South America", "Oceania", "Polar", "Regions" };
            foreach (var destination in destinations)
            {
                await dbContext.Destinations.AddAsync(new Destination
                {
                    Name = destination,
                });
            }
        }
    }
}
