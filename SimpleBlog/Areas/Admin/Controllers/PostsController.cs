using Microsoft.AspNetCore.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PostsController : Controller
    {
        public IActionResult Index()
        {
            return Content("Admin Posts");
        }
    }
}
