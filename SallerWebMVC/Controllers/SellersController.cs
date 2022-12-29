using Microsoft.AspNetCore.Mvc;

namespace SallerWebMVC.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
