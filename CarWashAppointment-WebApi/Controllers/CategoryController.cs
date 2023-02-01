using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CarWashAppointment_WebApi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager cm=new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetAllCategories();
            return View(values);
        }
    }
}
