namespace WebApi.Models
{
	public class AppointmentListModel
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
