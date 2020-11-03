namespace TravelBookingPortal.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TravelBookingPortal.Data.Common.Models;

    public class Company : BaseDeletableModel<int>
    {
        public Company()
        {
            this.Tours = new HashSet<Tour>();
            this.ReviewsCompanies = new HashSet<ReviewCompany>();
        }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Address { get; set; }

        [EmailAddress]
        public string EmailAddress { get; set; }

        [Required]
        public string AboutUs { get; set; }

        public string WhyBookWithUs { get; set; }

        public string YearEstablished { get; set; }

        public string Logo { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

        public virtual ICollection<ReviewCompany> ReviewsCompanies { get; set; }

    }
}
