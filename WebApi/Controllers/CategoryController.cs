using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[EnableCors]
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		ICategoryService _categoryService;

		public CategoryController(ICategoryService categoryService)
		{
			_categoryService = categoryService;
		}

		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var value = _categoryService.TGetAll();
			return Ok(value);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var value = _categoryService.TGetById(id);
			return Ok(value);
		}
		[HttpPost("add")]
		public IActionResult Add(Category category) 
		{
			using var c = new Context();
			c.Add(category);
			c.SaveChanges();
			return Ok(c);
		}
		[HttpPut("update")]
		public IActionResult Update(Category category)
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
		[HttpDelete("delete")]
		public IActionResult Delete(Category category)
		{
			using var c = new Context();
			c.Remove(category);
			c.SaveChanges();
			return Ok(c);
		}
	}
}
