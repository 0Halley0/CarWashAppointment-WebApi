using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class LoginModel
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Email { get; set; } = string.Empty;
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Password { get; set; } = string.Empty;
	}
}
