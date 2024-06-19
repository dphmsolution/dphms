using Microsoft.AspNetCore.Mvc;

namespace DPHMS.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
