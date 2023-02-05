using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class CustomerModel
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int CustomerId { get; set; }
		[Required(ErrorMessage ="Lütfen boş alanları doldurunuz.")]
		public string ImageUrl { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string PlateNumber { get; set; }
	}
}
