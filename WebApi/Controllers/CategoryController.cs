using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		[HttpGet("getAll")]
		public IActionResult TGetAll()
		{
			using var c = new Context();
			var values=c.Categories.ToList();
			return Ok(values);
		}
		[HttpGet("getById")]
		public IActionResult TGet(int id)
		{
			using var c = new Context();
			var category = c.Categories.Find(id);
			if(category == null) 
			{ 
				return NotFound();
			}
			return Ok(category);
		}
		[HttpPost("add")]
		public IActionResult TAdd(Category category) 
		{
			using var c = new Context();
			c.Add(category);
			c.SaveChanges();
			return Ok(c);
		}
		[HttpPut("update")]
		public IActionResult TUpdate(Category category)
		{
			using var c = new Context();
			var cat = c.Find<Category>(category.CategoryId);
			if (cat == null)
			{
				return NotFound();
			}
			else
			{
				cat.CategoryName = category.CategoryName;
				c.Update(cat);
				c.SaveChanges();
				return Ok(c);
			}
		}
		[HttpDelete("{id}")]
		public IActionResult TDelete(int id)
		{
			using var c = new Context();
			var category=c.Categories.Find(id);
			if (category == null)
			{
				return NotFound();
			}
			else
			{
				c.Remove(category);
				c.SaveChanges();
				return Ok(c);
			}
		}
	}
}
