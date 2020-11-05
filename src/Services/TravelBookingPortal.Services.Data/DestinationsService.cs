using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelBookingPortal.Data.Common.Repositories;
using TravelBookingPortal.Data.Models;
using TravelBookingPortal.Services.Mapping;

namespace TravelBookingPortal.Services.Data
{
    public class DestinationsService : IDestinationsService
    {
        private readonly IDeletableEntityRepository<Destination> destinationRepository;

        public DestinationsService(IDeletableEntityRepository<Destination> destinationRepository)
        {
            this.destinationRepository = destinationRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Destination> query = this.destinationRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }
            return query.To<T>().ToList();
        }

        public T GetByName<T>(string name)
        {
            var destination = this.destinationRepository.All().Where(x => x.Name == name).To<T>().FirstOrDefault();
            return destination;
        }

        public T GetById<T>(int id)
        {
            var destination = this.destinationRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return destination;
        }
    }
}
