using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOLayer.DTOs.AppointmentDTOs
{
	public class AppointmentListDTO
	{
		public int AppointmentId { get; set; }
		public int Cost { get; set; }
		public int Duration { get; set; }
		public string? Description { get; set; }
		public string? WashOption { get; set; }
		public bool AppointmentStatus { get; set; }
		public String AppointmentDate { get; set; }
		public String CreatedAt { get; set; }
	}
}
