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
    [Table("CarWash")]
    public class CarWash
	{
        [Key]
        public int CarWashId { get; set; }
		public string ImageUrl { get; set; }
		public string PhoneNumber { get; set; }
		public string Password { get; set; }
		public string CarWashName { get; set; }
        public string CarWashAddress { get; set; }
        public string CarWashCity { get; set; }
        public string CarWashDistrict { get; set; }
        public List<Appointment> Appointments { get; set; }
    }
}
