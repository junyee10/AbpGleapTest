using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace AbpGleapTest.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbpGleapTestControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}