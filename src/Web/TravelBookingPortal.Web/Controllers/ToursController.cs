namespace TravelBookingPortal.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TravelBookingPortal.Services.Data;
    using TravelBookingPortal.Web.ViewModels.Tours;

    public class ToursController : BaseController
    {
        private readonly ICompaniesService companiesService;
        private readonly IToursService toursService;

        public ToursController(ICompaniesService companiesService, IToursService toursService)
        {
            this.companiesService = companiesService;
            this.toursService = toursService;
        }

        public IActionResult All()
        {
            var viewModel = new AllToursxViewModel();

            var tours = this.toursService.GetAll<TourViewModel>();
            viewModel.Tours = tours;

            return this.View(viewModel);
        }

        public IActionResult ById(int id)
        {
            var postViewModel = this.toursService.GetById<TourDetailsViewModel>(id);
            if (postViewModel == null)
            {
                return this.NotFound();
            }

            return this.View(postViewModel);
        }
        //public IActionResult Details(int id)
        //{
        //    var postViewModel = this.toursService.GetById<TourDetailsViewModel>(id);
        //    if (postViewModel == null)
        //    {
        //        return this.NotFound();
        //    }

        //    return this.View(postViewModel);
        //}

    }
}
