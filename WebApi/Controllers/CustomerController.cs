using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		ICustomerService _customerService;

		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}
		[HttpGet("getAll")]
		public IActionResult Get()
		{
			var result = _customerService.TGetAll();
			return Ok(result);
		}
		[HttpGet("getById")]
		public IActionResult GetById(int id)
		{
			var result= _customerService.TGetById(id);
			return Ok(result);
		}
	}
}
