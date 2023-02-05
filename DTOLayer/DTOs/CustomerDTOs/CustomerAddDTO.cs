using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.CustomerDTOs
{
	public class CustomerAddDTO
	{
		public int CustomerId { get; set; }
		public string ImageUrl { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PlateNumber { get; set; }
	}
}
