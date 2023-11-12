using Microsoft.AspNetCore.Mvc;

namespace PizzaShop.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
