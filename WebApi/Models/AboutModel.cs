using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class AboutModel
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int AboutId { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Details1 { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string Details2 { get; set; }
		public string? Image1 { get; set; }
		public string? Image2 { get; set; }
		public string? MapLocation { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public bool AboutStatus { get; set; }
	}
}
