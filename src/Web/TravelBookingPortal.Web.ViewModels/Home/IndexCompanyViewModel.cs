namespace TravelBookingPortal.Web.ViewModels.Home
{
    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class IndexCompanyViewModel : IMapFrom<Company>
    {
        public string Name { get; set; }

        public string Logo { get; set; }

        public string Url { get; set; }
    }
}
