using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
