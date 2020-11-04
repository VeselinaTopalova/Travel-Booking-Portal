using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBookingPortal.Web.Controllers
{
    public class DestinationsController : BaseController
    {
        

        public DestinationsController()
        {
        }

        public IActionResult ByName()
        {
           
            return this.View();
        }
    }
}
