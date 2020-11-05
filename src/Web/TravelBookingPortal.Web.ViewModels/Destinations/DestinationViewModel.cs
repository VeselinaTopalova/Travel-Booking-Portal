namespace TravelBookingPortal.Web.ViewModels.Destinations
{
    using System.Collections.Generic;

    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Services.Mapping;

    public class DestinationViewModel : IMapFrom<Destination>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<Tour> Tours { get; set; }
    }
}
