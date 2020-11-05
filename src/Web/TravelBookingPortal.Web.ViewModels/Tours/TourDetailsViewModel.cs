namespace TravelBookingPortal.Web.ViewModels.Tours
{
    using System;
    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class TourDetailsViewModel : IMapFrom<Tour>
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Duration { get; set; }

        public decimal PriceTotal { get; set; }

        public string Image { get; set; }

        public DateTime DepartureDate { get; set; } // => this.DepartureDate.ToString();

        public DateTime ReturnDate { get; set; }

        public string Highlights { get; set; }

        public string Included { get; set; }

        public string Itinerary { get; set; }

        public string CompanyName { get; set; }

        public string CompanyLogo { get; set; }

        public int CompanyId { get; set; }

        //public string DepartureTimeFormatted => this.DepartureTime.ToString("s");
    }
}
