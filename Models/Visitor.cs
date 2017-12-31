using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class Visitor : Person
	{
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? VisitDate { get; set; }

		public string TimeAvailable { get; set; }

		public bool VisitYou { get; set; }
	}
}
