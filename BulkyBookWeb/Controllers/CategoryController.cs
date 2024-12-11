using BulkyBookWeb.Data;
using BulkyBookWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBookWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            //var objCategoryList = _db.Categories.ToList();  
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                //ModelState.AddModelError("CustomError", "The displayorder can not exactly match the Name."); go in summary
                ModelState.AddModelError("Name", "The displayorder can not exactly match the Name.");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                //return RedirectToAction("Index"(action name),"Home"(controller name)); if want to redirct in other controller
                TempData["Success"] = "Category created successfully.";
                return RedirectToAction("Index"); // if redirecting in same controller
            }

            return View(obj);
        }

        //GET
        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            // way to retrive data
            var obj = _db.Categories.Find(id);
            //var obj = _db.Categories.FirstOrDefault(u => u.Id == id);
            //var obj = _db.Categories.SingleOrDefault(u => u.Id == id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                //ModelState.AddModelError("CustomError", "The displayorder can not exactly match the Name."); go in summary
                ModelState.AddModelError("Name", "The displayorder can not exactly match the Name.");
            }

            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["Success"] = "Category updated successfully.";
                //return RedirectToAction("Index"(action name),"Home"(controller name)); if want to redirct in other controller
                return RedirectToAction("Index"); // if redirecting in same controller
            }

            return View(obj);
        }

        //GET
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // way to retrive data
            var obj = _db.Categories.Find(id);

            if (obj == null) { return NotFound(); }

            return View(obj);
        }

        //POST
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCategory(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            // way to retrive data
            var obj = _db.Categories.Find(id);

            if (obj == null) { return NotFound(); }

            _db.Categories.Remove(obj);
            _db.SaveChanges();
            TempData["Success"] = "Category deleted successfully.";
            return RedirectToAction("Index"); 
        }
    }
}

