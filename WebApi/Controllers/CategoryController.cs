using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
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
			List<CategoryModel> list = new List<CategoryModel>();
			foreach(Category item in _categoryService.TGetAll())
			{
				CategoryModel model = new CategoryModel();
				model.CategoryId = item.CategoryId;
				model.CategoryName = item.CategoryName;
				model.CategoryDescription = item.CategoryDescription;
				model.CategoryStatus = item.CategoryStatus;
				list.Add(model);
			}
			return Ok(list);
			 
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var value = _categoryService.TGetById(id);
			return Ok(value);
		}
		[HttpPost("add")]
		public IActionResult Add(CategoryModel categoryModel) 
		{
			Category category= new Category();
			category.CategoryId= categoryModel.CategoryId;
			category.CategoryName= categoryModel.CategoryName;
			category.CategoryDescription= categoryModel.CategoryDescription;
			category.CategoryStatus= categoryModel.CategoryStatus;
			_categoryService.TAdd(category);
			return Ok(category);
		}
		[HttpPut("update")]
		public IActionResult Update(CategoryModel categoryModel)
		{
			Category category = new Category();
			category.CategoryId = categoryModel.CategoryId;
			category.CategoryName = categoryModel.CategoryName;
			category.CategoryDescription = categoryModel.CategoryDescription;
			category.CategoryStatus = categoryModel.CategoryStatus;
			_categoryService.TUpdate(category);
			return Ok(category);
		}
		[HttpDelete("delete")]
		public IActionResult Delete(CategoryModel categoryModel)
		{
			Category category = new Category();
			category.CategoryId = categoryModel.CategoryId;
			category.CategoryName = categoryModel.CategoryName;
			category.CategoryDescription = categoryModel.CategoryDescription;
			category.CategoryStatus = categoryModel.CategoryStatus;
			_categoryService.TDelete(category);
			return Ok(category);
		}
	}
}
