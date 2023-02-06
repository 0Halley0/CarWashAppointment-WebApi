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
	public class AboutController : ControllerBase
	{
		private readonly IAboutService _aboutService;

		public AboutController(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			List<AboutModel> list = new List<AboutModel>();
			foreach (About item in _aboutService.TGetAll())
			{
				AboutModel model = new AboutModel();
				model.AboutId = item.AboutId;
				model.AboutStatus = item.AboutStatus;
				model.Details1 = item.Details1;
				model.Details2 = item.Details2;
				model.Image1= item.Image1;
				model.Image2 = item.Image2;
				list.Add(model);
			}
			return Ok(list);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var values=_aboutService.TGetById(id);
			return Ok(values);
		}
		[HttpPost("add")]
		public IActionResult Add(AboutModel aboutModel)
		{
			About about= new About();
			about.AboutId = aboutModel.AboutId;
			about.AboutStatus = aboutModel.AboutStatus;
			about.Details1 = aboutModel.Details1;
			about.Details2 = aboutModel.Details2;
			about.Image1 = aboutModel.Image1;
			about.Image2 = aboutModel.Image2;
			_aboutService.TAdd(about);
			return Ok(about);
		}
		[HttpPut("update")]
		public IActionResult Update(AboutModel aboutModel)
		{
			About about = new About();
			about.AboutId = aboutModel.AboutId;
			about.AboutStatus = aboutModel.AboutStatus;
			about.Details1 = aboutModel.Details1;
			about.Details2 = aboutModel.Details2;
			about.Image1 = aboutModel.Image1;
			about.Image2 = aboutModel.Image2;
			_aboutService.TUpdate(about);
			return Ok(about);
		}
		[HttpDelete("delete")]
		public IActionResult Delete(AboutModel aboutModel)
		{
			About about = new About();
			about.AboutId = aboutModel.AboutId;
			about.AboutStatus = aboutModel.AboutStatus;
			about.Details1 = aboutModel.Details1;
			about.Details2 = aboutModel.Details2;
			about.Image1 = aboutModel.Image1;
			about.Image2 = aboutModel.Image2;
			_aboutService.TDelete(about);
			return Ok(about);
		}
	}
}
