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

        public T GetByName<T>(string name)
        {
            var company = this.companyRepository.All().Where(x => x.Name == name).To<T>().FirstOrDefault();
            return company;
        }

        public T GetById<T>(int id)
        {
            var company = this.companyRepository.All().Where(x => x.Id == id)
                .To<T>().FirstOrDefault();
            return company;
        }
    }
}
