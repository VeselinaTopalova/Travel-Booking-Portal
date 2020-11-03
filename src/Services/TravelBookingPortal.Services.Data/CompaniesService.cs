namespace TravelBookingPortal.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;

    using TravelBookingPortal.Data.Common.Repositories;
    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class CompaniesService : ICompaniesService
    {
        private readonly IDeletableEntityRepository<Company> companyRepository;

        public CompaniesService(IDeletableEntityRepository<Company> companyRepository)
        {
            this.companyRepository = companyRepository;
        }

        public IEnumerable<T> GetAll<T>(int? count = null)
        {
            IQueryable<Company> query = this.companyRepository.All().OrderBy(x => x.Name);
            if (count.HasValue)
            {
                query = query.Take(count.Value);
            }
            return query.To<T>().ToList();
        }
    }
}
