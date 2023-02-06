using AutoMapper;
using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using DTOLayer.DTOs.CustomerDTOs;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApi.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace WebApi.Controllers
{
	[EnableCors]
	[Route("api/[controller]")]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerService _customerService;
		public CustomerController(ICustomerService customerService)
		{
			_customerService = customerService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			List<CustomerModel> list = new List<CustomerModel>();
			foreach (Customer item in _customerService.TGetAll())
			{
				CustomerModel model = new CustomerModel();
				model.CustomerId = item.CustomerId;
				model.ImageUrl = item.ImageUrl;
				model.FirstName = item.FirstName;
				model.LastName = item.LastName;
				model.PhoneNumber= item.PhoneNumber;
				model.Email = item.Email;
				model.Password= item.Password;
				model.PlateNumber= item.PlateNumber;
				list.Add(model);
			}
			return Ok(list);
			//var value = _mapper.Map<List<CustomerListDTO>>(_customerService.TGetAll());
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var value=_customerService.TGetById(id);
			return Ok(value);
		}
		[HttpPost("add")]
		public IActionResult Add(CustomerModel customerModel)
		{
			Customer customer = new Customer();
			customer.CustomerId = customerModel.CustomerId;
			customer.ImageUrl = customerModel.ImageUrl;
			customer.FirstName = customerModel.FirstName;
			customer.LastName = customerModel.LastName;
			customer.PhoneNumber = customerModel.PhoneNumber;
			customer.Email = customerModel.Email;
			customer.Password = customerModel.Password;
			customer.PlateNumber = customerModel.PlateNumber;
			_customerService.TAdd(customer);
			return Ok(customer);
		}
		[HttpPut("update")]
		public IActionResult Update(CustomerModel customerModel)
		{
			Customer customer = new Customer();
			customer.CustomerId = customerModel.CustomerId;
			customer.ImageUrl = customerModel.ImageUrl;
			customer.FirstName = customerModel.FirstName;
			customer.LastName = customerModel.LastName;
			customer.PhoneNumber = customerModel.PhoneNumber;
			customer.Email = customerModel.Email;
			customer.Password = customerModel.Password;
			customer.PlateNumber = customerModel.PlateNumber;
			_customerService.TUpdate(customer);
			return Ok(customer);
		}
		[HttpDelete("delete")]
		public IActionResult Delete(CustomerModel customerModel)
		{
			Customer customer = new Customer();
			customer.CustomerId = customerModel.CustomerId;
			customer.ImageUrl = customerModel.ImageUrl;
			customer.FirstName = customerModel.FirstName;
			customer.LastName = customerModel.LastName;
			customer.PhoneNumber = customerModel.PhoneNumber;
			customer.Email = customerModel.Email;
			customer.Password = customerModel.Password;
			customer.PlateNumber = customerModel.PlateNumber;
			_customerService.TDelete(customer);
			return Ok(customer);
		}
	}
}
