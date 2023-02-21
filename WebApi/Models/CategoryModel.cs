﻿using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class CategoryModel
	{
		public int CategoryId { get; set; }
		public string CategoryName { get; set; }
		public string CategoryDescription { get; set; }
		public bool CategoryStatus { get; set; }
	}
}
