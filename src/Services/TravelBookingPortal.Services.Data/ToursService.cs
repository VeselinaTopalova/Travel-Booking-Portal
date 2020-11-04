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

        public IEnumerable<T> GetTopPopular<T>(int? count = null)
        {
            IQueryable<Tour> query = this.tourRepository.All().OrderBy(x => x.Users.Count).Take(3);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }
            return query.To<T>().ToList();
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Tour> query = this.tourRepository.All().OrderBy(x => x.DepartureDate);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }
            return query.To<T>().ToList();
        }

        public T GetByName<T>(string name)
        {
            throw new System.NotImplementedException();
        }

        public T GetById<T>(int id)
        {
            var post = this.tourRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return post;
        }

        //public TripDetailsViewModel GetDetails(string id)
        //{
        //    var trip = this.db.Trips.Where(x => x.Id == id)
        //        .Select(x => new TripDetailsViewModel
        //        {
        //            DepartureTime = x.DepartureTime,
        //            Description = x.Description,
        //            EndPoint = x.EndPoint,
        //            Id = x.Id,
        //            ImagePath = x.ImagePath,
        //            Seats = x.Seats,
        //            StartPoint = x.StartingPoint,
        //            UsedSeats = x.UserTrips.Count(),
        //        })
        //        .FirstOrDefault();
        //    return trip;
        //}
    }
}
