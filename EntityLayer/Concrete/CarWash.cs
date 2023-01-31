using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CarWash
    {
        [Key]
        public int CarWashId { get; set; }
        public int ClientNumber { get; set; }
        public int CarWashPhoneNumber { get; set; }
        public string Password { get; set; }
        public string CarWashName { get; set; }
        public string CarWashAddress { get; set; }
        public string CarWashCity { get; set; }
    }
}
