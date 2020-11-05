namespace TravelBookingPortal.Web.ViewModels.Home
{
    using System.Collections.Generic;

    public class IndexViewModel
    {
        public IEnumerable<IndexTourViewModel> Tours { get; set; }

        public IEnumerable<IndexCompanyViewModel> Companies { get; set; }

        public IEnumerable<IndexDestinationViewModel> Destinations { get; set; }
    }
}
