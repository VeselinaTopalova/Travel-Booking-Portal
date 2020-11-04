namespace TravelBookingPortal.Web.ViewModels.Tours
{
    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class TourViewModel : IMapFrom<Tour>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public decimal PriceTotal { get; set; }

        public string Image { get; set; }
    }
}