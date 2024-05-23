using Microsoft.AspNetCore.Mvc;

namespace GR.TelaLogin.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
