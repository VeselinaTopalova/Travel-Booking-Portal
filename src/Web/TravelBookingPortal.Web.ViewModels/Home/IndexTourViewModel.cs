namespace TravelBookingPortal.Web.ViewModels.Home
{
    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class IndexTourViewModel : IMapFrom<Tour>
    {
        public string Name { get; set; }

        public int Duration { get; set; }

        public decimal PriceTotal { get; set; }

        public string Image { get; set; }
    }
}