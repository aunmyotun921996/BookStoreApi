using Microsoft.AspNetCore.Mvc;

namespace BookStoreApi.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
