using Microsoft.AspNetCore.Mvc;
using Rajor_Project_mvc.Data;
using Rajor_Project_mvc.Models;

namespace Rajor_Project_mvc.Controllers
{
    public class CatagoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CatagoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<Catagory> result = _db.Catagories.ToList();
            return View(result);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Catagory obj)
        {
            if (ModelState.IsValid)
            {
                var catagoryObj = _db.Catagories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Catagory created successfully";
                return RedirectToAction("Index");
            }
            //if the validation fails stay at the current page
           return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Catagory obj = _db.Catagories.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(Catagory obj)
        {
            if(ModelState.IsValid)
            {
                _db.Catagories.Update(obj);
                _db.SaveChanges();
                TempData["update"] = "Catagory updated successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Catagory obj = _db.Catagories.Find(id);

            if (obj == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            if (ModelState.IsValid)
            {
                var obj = _db.Catagories.Find(id);
                _db.Remove(obj);
                _db.SaveChanges();
                TempData["delete"] = "Catagory deleted successfully";
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
