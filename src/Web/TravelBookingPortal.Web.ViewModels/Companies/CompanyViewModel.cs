namespace TravelBookingPortal.Web.ViewModels.Companies
{
    using System.Collections.Generic;

    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class CompanyViewModel : IMapFrom<Company>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string EmailAddress { get; set; }

        public string AboutUs { get; set; }

        public string WhyBookWithUs { get; set; }

        public string YearEstablished { get; set; }

        public string Logo { get; set; }

        public IEnumerable<ReviewCompanyViewModel> ReviewsCompanies { get; set; }

        public IEnumerable<Tour> Tours { get; set; }
    }
}
