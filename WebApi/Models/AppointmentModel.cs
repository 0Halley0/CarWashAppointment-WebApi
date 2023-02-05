using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class AppointmentModel
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int AppointmentId { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int Cost { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int Duration { get; set; }
		public string? Description { get; set; }
		public string? WashOption { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public bool AppointmentStatus { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public DateTime AppointmentDate { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public DateTime CreatedAt { get; set; }
	}
}
