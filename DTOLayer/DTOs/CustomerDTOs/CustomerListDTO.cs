using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.CustomerDTOs
{
	public class CustomerListDTO
	{
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string FirstName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string LastName { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string PhoneNumber { get; set; }
		[Required(ErrorMessage = "Lütfen boş alanları doldurunuz.")]
		public string PlateNumber { get; set; }
	}
}
