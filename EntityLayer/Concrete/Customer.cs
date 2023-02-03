using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    [Table("Customer")]
    public class Customer
	{
		[Key]
		public int CustomerId { get; set; }
		public string ImageUrl { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string PlateNumber { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
