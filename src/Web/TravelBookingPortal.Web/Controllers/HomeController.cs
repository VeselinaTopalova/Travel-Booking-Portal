namespace TravelBookingPortal.Web.Controllers
{
    using System.Diagnostics;
    using System.Linq;
    using Microsoft.AspNetCore.Mvc;
    using TravelBookingPortal.Data;
    using TravelBookingPortal.Web.ViewModels;
    using TravelBookingPortal.Web.ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var viewModel = new IndexViewModel();
            var tours = this.db.Tours.OrderByDescending(x => x.Users.Count).Select(x => new IndexTourViewModel
            {
                Image = x.Image,
                Duration = x.Duration,
                PriceTotal = x.PriceTotal,
                Name = x.Name,
            }).Take(3).ToList();
            viewModel.Tours = tours;

            var companies = this.db.Companies.Select(x => new IndexCompanyViewModel
            {
                Name = x.Name,
                Logo = x.Logo,
            }).ToList();
            viewModel.Companies = companies;

            return this.View(viewModel);
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(
                new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
