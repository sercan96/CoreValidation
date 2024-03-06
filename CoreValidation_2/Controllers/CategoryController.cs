using CoreValidation_2.Models.ContextClasses;
using CoreValidation_2.Models.Entities;
using CoreValidation_2.Views.ViewModels.PureVM.Categories;
using Microsoft.AspNetCore.Mvc;

namespace CoreValidation_2.Controllers
{
    public class CategoryController : Controller
    {
        MyContext _db;
        public CategoryController(MyContext db)
        {
            _db = db;
        }
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(CategoryRequestModel category)
        {
            // Server Side Validation'da bilgiler back end'e gönderilir ve kontorl öyle sağlanır.
            if(ModelState.IsValid) // Model durumu validation'dan geçmiş ise
            {
                // Mapping (Bir tipin bilgilerinin diğer istenilen tipe aktarılmasıdır)
                // _db.Product.Select(x=> new {})
                //_db.Category.Add(category);

                Category c = new()
                {
                    CategoryName = category.CategoryName,
                    Description = category.Description,
                };

                _db.Category.Add(c);
                _db.SaveChanges();
                return RedirectToAction("GetCategories");
            }

            return View(category);
        }

        public IActionResult GetCategories()
        {
            return View();
        }
    }
}
