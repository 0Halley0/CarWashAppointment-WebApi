using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

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
			List<AppointmentModel> list = new List<AppointmentModel>();
			foreach (Appointment item in _appointmentService.TGetAll())
			{
				AppointmentModel model = new AppointmentModel();
				model.AppointmentId = item.AppointmentId;
				model.Cost = item.Cost;
				model.Duration = item.Duration;
				model.Description = item.Description;
				model.WashOption= item.WashOption;
				model.AppointmentStatus = item.AppointmentStatus;
				model.AppointmentDate = item.AppointmentDate;
				model.CreatedAt = item.CreatedAt;
				list.Add(model);
			}
			return Ok(list);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var values=_appointmentService.TGetById(id);
			return Ok(values);
		}
		[HttpPost("add")]
		public IActionResult Add(AppointmentModel appointmentModel)
		{
			Appointment appointment = new Appointment();
			appointment.AppointmentId = appointmentModel.AppointmentId;
			appointment.Cost = appointmentModel.Cost;
			appointment.Duration = appointmentModel.Duration;
			appointment.Description = appointmentModel.Description;
			appointment.WashOption = appointmentModel.WashOption;
			appointment.AppointmentStatus = appointmentModel.AppointmentStatus;
			appointment.AppointmentDate = appointmentModel.AppointmentDate;
			appointment.CreatedAt = appointmentModel.CreatedAt;
			_appointmentService.TAdd(appointment);
			return Ok(appointment);
		}
		[HttpPut("update")]
		public IActionResult Update(AppointmentModel appointmentModel)
		{
			Appointment appointment = new Appointment();
			appointment.AppointmentId = appointmentModel.AppointmentId;
			appointment.Cost = appointmentModel.Cost;
			appointment.Duration = appointmentModel.Duration;
			appointment.Description = appointmentModel.Description;
			appointment.WashOption = appointmentModel.WashOption;
			appointment.AppointmentStatus = appointmentModel.AppointmentStatus;
			appointment.AppointmentDate = appointmentModel.AppointmentDate;
			appointment.CreatedAt = appointmentModel.CreatedAt;
			_appointmentService.TUpdate(appointment);
			return Ok(appointment);

		}
		[HttpDelete("delete")]
		public IActionResult Delete(AppointmentModel appointmentModel)
		{
			Appointment appointment = new Appointment();
			appointment.AppointmentId = appointmentModel.AppointmentId;
			appointment.Cost = appointmentModel.Cost;
			appointment.Duration = appointmentModel.Duration;
			appointment.Description = appointmentModel.Description;
			appointment.WashOption = appointmentModel.WashOption;
			appointment.AppointmentStatus = appointmentModel.AppointmentStatus;
			appointment.AppointmentDate = appointmentModel.AppointmentDate;
			appointment.CreatedAt = appointmentModel.CreatedAt;
			_appointmentService.TDelete(appointment);
			return Ok(appointment);
		}
	}
}
