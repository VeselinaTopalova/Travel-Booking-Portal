namespace TravelBookingPortal.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using TravelBookingPortal.Data.Common.Repositories;
    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class ToursService : IToursService
    {
        private readonly IDeletableEntityRepository<Tour> tourRepository;

        public ToursService(IDeletableEntityRepository<Tour> tourRepository)
        {
            this.tourRepository = tourRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Tour> query = this.tourRepository.All().OrderBy(x => x.Users.Count).Take(3);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }
            return query.To<T>().ToList();
        }
    }
}
