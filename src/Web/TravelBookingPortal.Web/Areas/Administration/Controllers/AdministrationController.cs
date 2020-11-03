namespace TravelBookingPortal.Web.Areas.Administration.Controllers
{
    using TravelBookingPortal.Common;
    using TravelBookingPortal.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
