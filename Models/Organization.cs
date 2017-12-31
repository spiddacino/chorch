using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class Organization
	{
		public int Id { get; set; }

		[Required, Display(Name = "Organization Name")]
		[StringLength(40, ErrorMessage = "Limit Organization name to 30 characters.")]
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

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime FoundedDate { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime OpenDate { get; set; }

		public Person Founder { get; set; }

		public string LogoUrl { get; set; }

		public string WebUrl { get; set; }

		[RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]
		public String Email { get; set; }

		public string Motto { get; set; }


	}
}
