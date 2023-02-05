using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
	public class CategoryModel
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public int CategoryId { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string CategoryName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string CategoryDescription { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public bool CategoryStatus { get; set; }
	}
}
