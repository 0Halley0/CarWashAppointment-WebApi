using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CarWashAppointment_WebApi.Controllers
{
	public class AppointmentController: Controller
	{
		AppointmentManager appointmentManager =new AppointmentManager(new EfAppointmentRepository());
		public IActionResult Index()
		{
			var values = appointmentManager.GetListWithCategory();
			return View(values);
		}
		public IActionResult AppointmentDetails(int id) 
		{ 
			return View();
		}
	}
}
