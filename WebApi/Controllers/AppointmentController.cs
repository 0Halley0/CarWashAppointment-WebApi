using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[EnableCors]
	[Route("api/[controller]")]
	[ApiController]
	public class AppointmentController : ControllerBase
	{
		private readonly IAppointmentService _appointmentService;

		public AppointmentController(IAppointmentService appointmentService)
		{
			_appointmentService = appointmentService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var values=_appointmentService.TGetAll();
			return Ok(values);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var values=_appointmentService.TGetById(id);
			return Ok(values);
		}
	}
}
