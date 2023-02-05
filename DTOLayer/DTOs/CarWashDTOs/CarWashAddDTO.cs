using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.CarWashDTOs
{
	public class CarWashAddDTO
	{
		public int CarWashId { get; set; }
		public string ImageUrl { get; set; }
		public string PhoneNumber { get; set; }
		public string Password { get; set; }
		public string CarWashName { get; set; }
		public string CarWashAddress { get; set; }
		public string CarWashCity { get; set; }
		public string CarWashDistrict { get; set; }
	}
}
