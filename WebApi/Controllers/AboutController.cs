using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

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
			var values=_aboutService.TGetAll();
			return Ok(values);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var values=_aboutService.TGetById(id);
			return Ok(values);
		}
	}
}
