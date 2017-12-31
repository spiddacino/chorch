using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class Church
	{
		[Required, Display(Name = "Church Name")]
		public string Name { get; set; }

		[Required]
		public string Address { get; set; }

		[RegularExpression(@"^(\d{11})$", ErrorMessage = "Invalid Number")]
		public string Telephone1 { get; set; }

		[RegularExpression(@"^(\d{11})$", ErrorMessage = "Invalid Number")]
		public string Telephone2 { get; set; }

		[RegularExpression(@"^(\d{11})$", ErrorMessage = "Invalid Number")]
		public string Telephone3 { get; set; }

		public string Description { get; set; }

		//Indicates if fully chartered or not
		public ChurchStatus Status { get; set; }


		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime FoundedDate { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime LaunchDate { get; set; }

		//public Person SeniorPastor { get; set; }
		//public Person Secretary { get; set; }

		[RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]
		public String Email { get; set; }

		//public ChurchBD1 ChurchSuperGroup { get; set; }

	}
}
