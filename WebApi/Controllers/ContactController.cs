using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[EnableCors]
	[Route("api/[controller]")]
	[ApiController]
	public class ContactController : ControllerBase
	{
		IContactService _contactService;

		public ContactController(IContactService contactService)
		{
			_contactService = contactService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var value=_contactService.TGetAll();
			return Ok(value);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var value=_contactService.TGetById(id);
			return Ok(value);
		}
	}

}
