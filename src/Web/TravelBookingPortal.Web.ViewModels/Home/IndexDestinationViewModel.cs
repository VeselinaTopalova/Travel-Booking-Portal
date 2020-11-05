using System;
using System.Collections.Generic;
using System.Text;
using TravelBookingPortal.Data.Models;
using TravelBookingPortal.Services.Mapping;

namespace TravelBookingPortal.Web.ViewModels.Home
{
    public class IndexDestinationViewModel : IMapFrom<Destination>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
