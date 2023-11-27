using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PizzaShop.Data;
using PizzaShop.Models;
using System.Diagnostics;

namespace PizzaShop.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Pizza> pizza = _db.Pizza.AsEnumerable();
            return View(pizza);
        }

        public IActionResult Description(int id)
        {
            Pizza pizza = _db.Pizza.Find(id);

            if (pizza == null)
            {
                return NotFound(); // Jeżeli pizza o danym ID nie istnieje, zwróć błąd 404
            }

            return View(pizza);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
 
    }
}