using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class CarWashModel
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int CarWashId { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string ImageUrl { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string CarWashName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string CarWashAddress { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string CarWashCity { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string CarWashDistrict { get; set; }
	}
}
