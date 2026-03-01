using Microsoft.AspNetCore.Mvc;

namespace App.UI.Web.Areas.Auth.Controllers
{
    [Area("Auth")]
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
