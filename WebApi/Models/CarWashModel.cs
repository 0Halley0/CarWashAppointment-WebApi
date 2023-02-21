using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class CarWashModel
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
