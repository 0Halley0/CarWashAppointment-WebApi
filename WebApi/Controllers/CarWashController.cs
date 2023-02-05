﻿using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
	[EnableCors]
	[Route("api/[controller]")]
	[ApiController]
	public class CarWashController : ControllerBase
	{
		private readonly ICarWashService _carWashService;

		public CarWashController(ICarWashService carWashService)
		{
			_carWashService = carWashService;
		}
		[HttpGet("getAll")]
		public IActionResult GetAll()
		{
			var values=_carWashService.TGetAll();
			return Ok(values);
		}
		[HttpGet("getById")]
		public IActionResult Get(int id)
		{
			var values=_carWashService.TGetById(id);
			return Ok(values);
		}
	}
}
