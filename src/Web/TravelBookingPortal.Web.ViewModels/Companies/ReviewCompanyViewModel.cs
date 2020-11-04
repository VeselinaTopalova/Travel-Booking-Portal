using TravelBookingPortal.Data.Models;
using TravelBookingPortal.Services.Mapping;

namespace TravelBookingPortal.Web.ViewModels.Companies
{
    public class ReviewCompanyViewModel : IMapFrom<ReviewCompany>
    {
        public int Grade { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string UserUsername { get; set; }
    }
}