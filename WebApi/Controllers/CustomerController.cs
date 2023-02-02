using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			using var c = new Context();
			var values = c.Customers.ToList();
			return Ok(values);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			using var c = new Context();
			var customer = c.Customers.Find(id);
			if (customer == null)
			{
				return NotFound();
			}
			return Ok(customer);
		}
		[HttpPost("add")]
		public IActionResult Add(Customer customer)
		{
			using var c = new Context();
			c.Add(customer);
			c.SaveChanges();
			return Ok(c);
		}
		[HttpPut("update")]
		public IActionResult Update(Customer customer)
		{
			using var c = new Context();
			var cus = c.Find<Customer>(customer.CustomerId);
			if (cus == null)
			{
				return NotFound();
			}
			else
			{
				cus.PlateNumber = customer.PlateNumber;
				c.Update(cus);
				c.SaveChanges();
				return Ok(c);
			}
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			using var c = new Context();
			var customer = c.Customers.Find(id);
			if (customer == null)
			{
				return NotFound();
			}
			else
			{
				c.Remove(customer);
				c.SaveChanges();
				return Ok(c);
			}
		}
	}
}
