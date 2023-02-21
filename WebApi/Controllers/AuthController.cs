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
	public class AuthController : ControllerBase
	{
		public static Customer customer=new Customer();
		[HttpPost("login")]
		public async Task<ActionResult<Customer>> Login(LoginModel loginModel)
		{
			if (customer.Email != loginModel.Email)
			{
				return BadRequest("Böyle bir kullanıcı bulunmamakta.");
			}
			return Ok(customer);
		}
		
	}
}
