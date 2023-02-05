using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class ContactModel
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int ContactId { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Email { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Subject { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Message { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public DateTime CreatedAt { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public bool ContactStatus { get; set; }
	}
}
