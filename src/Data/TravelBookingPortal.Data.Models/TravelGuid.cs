namespace TravelBookingPortal.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TravelBookingPortal.Data.Common.Models;

    public class TravelGuid : BaseDeletableModel<int>
    {
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public int DestinationId { get; set; }

        public virtual Destination Destination { get; set; }
    }
}
