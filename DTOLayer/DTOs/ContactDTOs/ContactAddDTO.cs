using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.ContactDTOs
{
	public class ContactAddDTO
	{
		public int ContactId { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public string Subject { get; set; }
		public string Message { get; set; }
		public DateTime CreatedAt { get; set; }
		public bool ContactStatus { get; set; }
	}
}
