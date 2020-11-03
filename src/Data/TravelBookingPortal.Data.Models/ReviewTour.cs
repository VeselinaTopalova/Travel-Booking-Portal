namespace TravelBookingPortal.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using TravelBookingPortal.Data.Common.Models;

    public class ReviewTour : BaseDeletableModel<int>
    {
        [Required]
        public int Grade { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int TourId { get; set; }

        public virtual Tour Tour { get; set; }
    }
}
