using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AppUserDTOs
{
	public class CustomerAddDTO
	{
		public int CustomerId { get; set; }
		public string CustomerPhoneNumber { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string? CustomerImage1 { get; set; }
		public string? CustomerImage2 { get; set; }
		public string Password { get; set; }
		public string PlateNumber { get; set; }
	}
}
