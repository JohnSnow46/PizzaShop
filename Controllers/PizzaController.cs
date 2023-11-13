using Microsoft.AspNetCore.Mvc;
using PizzaShop.Data;
using PizzaShop.Models;

namespace PizzaShop.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ApplicationDbContext _db;
        public PizzaController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Pizza> objCategoryList = _db.Pizza.ToList();
            return View(objCategoryList);
        }
    }
}
