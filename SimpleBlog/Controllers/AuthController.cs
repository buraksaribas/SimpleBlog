using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
    }
}
