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
	public class CarWashController : ControllerBase
	{
		private readonly ICarWashService _carWashService;

		public CarWashController(ICarWashService carWashService)
		{
			_carWashService = carWashService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			List<CarWashModel> list = new List<CarWashModel>();
			foreach (CarWash item in _carWashService.TGetAll())
			{
				CarWashModel model = new CarWashModel();
				model.CarWashId = item.CarWashId;
				model.ImageUrl = item.ImageUrl;
				model.PhoneNumber = item.PhoneNumber;
				model.Password = item.Password;
				model.CarWashName = item.CarWashName;
				model.CarWashAddress = item.CarWashAddress;
				model.CarWashCity = item.CarWashCity;
				model.CarWashDistrict = item.CarWashDistrict;
				list.Add(model);
			}
			return Ok(list);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var values=_carWashService.TGetById(id);
			return Ok(values);
		}
		[HttpPost("add")]
		public IActionResult Add(CarWashModel carWashModel)
		{
			CarWash carWash = new CarWash();
			carWash.CarWashId = carWashModel.CarWashId;
			carWash.ImageUrl = carWashModel.ImageUrl;
			carWash.PhoneNumber = carWashModel.PhoneNumber;
			carWash.Password = carWashModel.Password;
			carWash.CarWashName = carWashModel.CarWashName;
			carWash.CarWashAddress = carWashModel.CarWashAddress;
			carWash.CarWashCity = carWashModel.CarWashCity;
			carWash.CarWashDistrict = carWashModel.CarWashDistrict;
			_carWashService.TAdd(carWash);
			return Ok(carWash);
		}
		[HttpPut("update")]
		public IActionResult Update(CarWashModel carWashModel)
		{
			CarWash carWash = new CarWash();
			carWash.CarWashId = carWashModel.CarWashId;
			carWash.ImageUrl = carWashModel.ImageUrl;
			carWash.PhoneNumber = carWashModel.PhoneNumber;
			carWash.Password = carWashModel.Password;
			carWash.CarWashName = carWashModel.CarWashName;
			carWash.CarWashAddress = carWashModel.CarWashAddress;
			carWash.CarWashCity = carWashModel.CarWashCity;
			carWash.CarWashDistrict = carWashModel.CarWashDistrict;
			_carWashService.TUpdate(carWash);
			return Ok(carWash);
		}
		[HttpDelete("delete")]
		public IActionResult Delete(CarWashModel carWashModel)
		{
			CarWash carWash = new CarWash();
			carWash.CarWashId = carWashModel.CarWashId;
			carWash.ImageUrl = carWashModel.ImageUrl;
			carWash.PhoneNumber = carWashModel.PhoneNumber;
			carWash.Password = carWashModel.Password;
			carWash.CarWashName = carWashModel.CarWashName;
			carWash.CarWashAddress = carWashModel.CarWashAddress;
			carWash.CarWashCity = carWashModel.CarWashCity;
			carWash.CarWashDistrict = carWashModel.CarWashDistrict;
			_carWashService.TDelete(carWash);
			return Ok(carWash);
		}
	}
}
