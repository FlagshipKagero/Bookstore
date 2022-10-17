using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Bookstore.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : BookstoreControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}