using Microsoft.AspNetCore.Mvc;
using PizzaShop.Data;
using PizzaShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace PizzaShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PizzaController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public PizzaController(ApplicationDbContext db, IWebHostEnvironment webHostEnvironment)
        {
            _db = db;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Pizza> objCategoryList = _db.Pizza.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Pizza obj, IFormFile? file)
        {
            string fileName;
            string pizzaPath;
            if (ModelState.IsValid)
            {

                string wwwRootPath = _webHostEnvironment.WebRootPath;
                if (file != null)
                {
                    fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    pizzaPath = Path.Combine(wwwRootPath, @"images\Pizza\");

                    using (var fileStream = new FileStream(Path.Combine(pizzaPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    obj.ImageUrl = @"\images\Pizza\" + fileName;
                }

                _db.Pizza.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pizza pizzaFromDb = _db.Pizza.Find(id);
            if (pizzaFromDb == null)
            {
                return NotFound();
            }
            return View(pizzaFromDb);
        }
        [HttpPost]
        public IActionResult Edit(int id, Pizza updatedPizza, IFormFile? file)
        {
            if (id != updatedPizza.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                Pizza existingPizza = _db.Pizza.Find(id);

                if (existingPizza == null)
                {
                    return NotFound();
                }

                existingPizza.Name = updatedPizza.Name;
                existingPizza.Description = updatedPizza.Description;
                existingPizza.Price = updatedPizza.Price;

                if (file != null)
                {
                    string wwwRootPath = _webHostEnvironment.WebRootPath;

                    if (!string.IsNullOrEmpty(existingPizza.ImageUrl))
                    {
                        string oldImagePath = Path.Combine(wwwRootPath, existingPizza.ImageUrl.TrimStart('\\'));
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }

                    string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);
                    string pizzaPath = Path.Combine(wwwRootPath, @"images\Pizza\");

                    using (var fileStream = new FileStream(Path.Combine(pizzaPath, fileName), FileMode.Create))
                    {
                        file.CopyTo(fileStream);
                    }

                    existingPizza.ImageUrl = @"\images\Pizza\" + fileName;
                }

                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View("Edit", updatedPizza);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pizza pizzaFromDb = _db.Pizza.Find(id);
            if (pizzaFromDb == null)
            {
                return NotFound();
            }
            return View(pizzaFromDb);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePOST(int? id)
        {
            Pizza obj = _db.Pizza.Find(id);
            if (obj == null)
            {
                NotFound();
            }

            Pizza existingPizza = _db.Pizza.Find(id);

            if (!string.IsNullOrEmpty(existingPizza.ImageUrl))
            {
                string wwwRootPath = _webHostEnvironment.WebRootPath;
                string oldImagePath = Path.Combine(wwwRootPath, existingPizza.ImageUrl.TrimStart('\\'));
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _db.Pizza.Remove(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Description(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Pizza pizzaFromDb = _db.Pizza.Find(id);
            if (pizzaFromDb == null)
            {
                return NotFound();
            }
            return View(pizzaFromDb);
        }
        [HttpPost]
        public IActionResult Description(int id, Pizza updatedPizza, IFormFile? file)
        {
            return View("Index");
        }
    }
}
