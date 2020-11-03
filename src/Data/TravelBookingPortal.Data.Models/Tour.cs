namespace TravelBookingPortal.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TravelBookingPortal.Data.Common.Models;

    public class Tour : BaseDeletableModel<int>
    {
        public Tour()
        {
            this.Users = new HashSet<ApplicationUser>();
            this.Reviews = new HashSet<ReviewTour>();
            this.Dscount = 0;
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public decimal Price { get; set; }

        public decimal Dscount { get; set; } // = 0;

        public decimal PriceTotal { get { return (this.Price - ((this.Dscount / 100) * this.Price)); } }

        [Required]
        public DateTime DepartureDate { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        public int Duration { get { return (int)(this.ReturnDate - this.DepartureDate).TotalDays; } }

        [Required]
        public string Highlights { get; set; }

        public string Included { get; set; }

        public string Itinerary { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public Activity Activity { get; set; }

        public int DestinationId { get; set; }

        public virtual Destination Destination { get; set; }

        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public virtual ICollection<ApplicationUser> Users { get; set; }

        public virtual ICollection<ReviewTour> Reviews { get; set; }
    }
}
