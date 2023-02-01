using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        public int Cost { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public string WashOption { get; set; }
        public bool AppointmentStatus { get; set; }
        public DateTime AppointmentDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public int CarWashId { get; set; }
        public CarWash CarWash { get; set; }
    }
}
