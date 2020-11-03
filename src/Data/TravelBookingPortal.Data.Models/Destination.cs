namespace TravelBookingPortal.Data.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    using TravelBookingPortal.Data.Common.Models;

    public class Destination : BaseDeletableModel<int>
    {
        public Destination()
        {
            this.Tours = new HashSet<Tour>();
        }

        [Required]
        public string Name { get; set; }

        public virtual ICollection<Tour> Tours { get; set; }

    }
}
