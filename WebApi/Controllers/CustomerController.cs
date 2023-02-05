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
			var value=_customerService.TGetAll();
			return Ok(value);
			//var value = _mapper.Map<List<CustomerListDTO>>(_customerService.TGetAll());
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var value=_customerService.TGetById(id);
			return Ok(value);
		}
	}
}
