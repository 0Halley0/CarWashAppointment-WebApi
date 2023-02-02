using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CarWashAppointment_WebApi.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager categoryManager=new CategoryManager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = categoryManager.TGetAll();
            return View(values);
        }
    }
}
