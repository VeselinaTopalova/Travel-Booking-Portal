namespace TravelBookingPortal.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using TravelBookingPortal.Data;
    using TravelBookingPortal.Data.Common.Repositories;
    using TravelBookingPortal.Data.Models;
    using TravelBookingPortal.Web.ViewModels;
    using TravelBookingPortal.Web.ViewModels.Home;
    using TravelBookingPortal.Services.Mapping;
    using TravelBookingPortal.Services.Data;

    public class HomeController : BaseController
    {
        private readonly ICompaniesService companiesService;
        private readonly IToursService toursService;

        public HomeController(ICompaniesService companiesService, IToursService toursService)
        {
            this.companiesService = companiesService;
            this.toursService = toursService;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            //var tours = this.toursRepository.All().OrderByDescending(x => x.Users.Count).Select(x => new IndexTourViewModel
            //{
            //    Image = x.Image,
            //    Duration = x.Duration,
            //    PriceTotal = x.PriceTotal,
            //    Name = x.Name,
            //}).Take(3).ToList();
            //var tours = this.toursRepository.All().To<IndexTourViewModel>().ToList();
            var tours = this.toursService.GetAll<IndexTourViewModel>();
            viewModel.Tours = tours;

            //var companies = this.companiesRepository.All().Select(x => new IndexCompanyViewModel
            //{
            //    Name = x.Name,
            //    Logo = x.Logo,
            //}).ToList();
            //var companies = this.companiesRepository.All().To<IndexCompanyViewModel>().ToList();
            //var companies = this.companiesService.GetAll<IndexCompanyViewModel>();
            //viewModel.Companies = companies;

            viewModel.Companies = this.companiesService.GetAll<IndexCompanyViewModel>();

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }
        public IActionResult AboutUs()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
