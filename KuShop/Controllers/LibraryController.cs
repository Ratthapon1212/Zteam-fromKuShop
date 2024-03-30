using Microsoft.AspNetCore.Mvc;

namespace KuShop.Controllers
{
    public class LibraryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllGame()
        {
            return View();
        }
    }
}
