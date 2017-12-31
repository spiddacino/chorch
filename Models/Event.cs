using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class Event
	{
		public int Id { get; set; }

		[Required]
		public string Title { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? StartDate { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? EndDate { get; set; }

		//Past or Scheduled
		[Required]
		public Status Status { get; set; }

		[Required, Display(Name = "Cost of Attendance")]
		public decimal Cost { get; set; }

		//Flier, pix
		public string ImageUrl { get; set; }

		//Number attending
		public int Attendance { get; set; }


	}
}
