namespace TravelBookingPortal.Web.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using TravelBookingPortal.Services.Data;
    using TravelBookingPortal.Web.ViewModels.Companies;

    public class CompaniesController : BaseController
    {
        private readonly ICompaniesService companiesService;

        public CompaniesController(ICompaniesService companiesService)
        {
            this.companiesService = companiesService;
        }

        public IActionResult ByName(string name)
        {
            var viewModel = this.companiesService.GetByName<CompanyViewModel>(name);
            return this.View(viewModel);
        }
    }
}
