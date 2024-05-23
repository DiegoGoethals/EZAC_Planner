namespace Ezac.Roster.Web.Models
{
	public class UserStatisticsViewModel
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public double TotalWorkload { get; set; }
		public double UserWorkload { get; set; }
		public double Percentage { get; set; }
	}
}
