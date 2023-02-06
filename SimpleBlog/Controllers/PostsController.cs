using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Controllers
{
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
