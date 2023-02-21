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
	public class AppointmentListController : ControllerBase
	{
		private readonly IAppointmentListService _appointmentListService;

		public AppointmentListController(IAppointmentListService appointmentListService)
		{
			_appointmentListService = appointmentListService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			List<AppointmentListModel> list = new List<AppointmentListModel>();
			foreach (AppointmentList item in _appointmentListService.TGetAll())
			{
				AppointmentListModel model = new AppointmentListModel();
				model.AppointmentId = item.AppointmentId;
				model.Cost = item.Cost;
				model.Duration = item.Duration;
				model.Description = item.Description;
				model.WashOption = item.WashOption;
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
			var values = _appointmentListService.TGetById(id);
			return Ok(values);
		}
		[HttpPost("add")]
		public IActionResult Add(AppointmentListModel appointmentListModel)
		{
			AppointmentList appointment = new AppointmentList();
			appointment.AppointmentId = appointmentListModel.AppointmentId;
			appointment.Cost = appointmentListModel.Cost;
			appointment.Duration = appointmentListModel.Duration;
			appointment.Description = appointmentListModel.Description;
			appointment.WashOption = appointmentListModel.WashOption;
			appointment.AppointmentStatus = appointmentListModel.AppointmentStatus;
			appointment.AppointmentDate = appointmentListModel.AppointmentDate;
			appointment.CreatedAt = appointmentListModel.CreatedAt;
			_appointmentListService.TAdd(appointment);
			return Ok(appointment);
		}
		[HttpPut("update")]
		public IActionResult Update(AppointmentListModel appointmentListModel)
		{
			AppointmentList appointment = new AppointmentList();
			appointment.AppointmentId = appointmentListModel.AppointmentId;
			appointment.Cost = appointmentListModel.Cost;
			appointment.Duration = appointmentListModel.Duration;
			appointment.Description = appointmentListModel.Description;
			appointment.WashOption = appointmentListModel.WashOption;
			appointment.AppointmentStatus = appointmentListModel.AppointmentStatus;
			appointment.AppointmentDate = appointmentListModel.AppointmentDate;
			appointment.CreatedAt = appointmentListModel.CreatedAt;
			_appointmentListService.TUpdate(appointment);
			return Ok(appointment);

		}
		[HttpDelete("delete")]
		public IActionResult Delete(AppointmentListModel appointmentListModel)
		{
			AppointmentList appointment = new AppointmentList();
			appointment.AppointmentId = appointmentListModel.AppointmentId;
			appointment.Cost = appointmentListModel.Cost;
			appointment.Duration = appointmentListModel.Duration;
			appointment.Description = appointmentListModel.Description;
			appointment.WashOption = appointmentListModel.WashOption;
			appointment.AppointmentStatus = appointmentListModel.AppointmentStatus;
			appointment.AppointmentDate = appointmentListModel.AppointmentDate;
			appointment.CreatedAt = appointmentListModel.CreatedAt;
			_appointmentListService.TDelete(appointment);
			return Ok(appointment);
		}
	}
}
