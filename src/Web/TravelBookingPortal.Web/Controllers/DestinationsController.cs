namespace TravelBookingPortal.Web.Controllers
{

    using Microsoft.AspNetCore.Mvc;
    using TravelBookingPortal.Services.Data;
    using TravelBookingPortal.Web.ViewModels.Destinations;

    public class DestinationsController : BaseController
    {
        private readonly IDestinationsService destinationsService;

        public DestinationsController(IDestinationsService destinationsService)
        {
            this.destinationsService = destinationsService;
        }

        public IActionResult ByName(string name)
        {
            var viewModel = this.destinationsService.GetByName<DestinationViewModel>(name);
            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var postViewModel = this.destinationsService.GetById<DestinationViewModel>(id);
            if (postViewModel == null)
            {
                return this.NotFound();
            }

            return this.View(postViewModel);
        }
    }
}
