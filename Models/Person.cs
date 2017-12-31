using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public abstract class Person
	{
		public int Id { get; set; }

		public string ImageUrl { get; set; }

		[Required]
		public OtherStatus Status { get; set; }

        [Required, Display(Name = "First Name")]
        [StringLength(30, ErrorMessage = "Limit first name to 30 characters.")]
        public string FirstName { get; set; }

        [Required, Display(Name = "Last Name")]
        [StringLength(30, ErrorMessage = "Limit last name to 30 characters.")]
        public string LastName { get; set; }

        public string Address { get; set; }

		[RegularExpression(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-‌​]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$", ErrorMessage = "Email is not valid")]
		public String Email { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? DateOfBirth { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? WeddingAnniversary { get; set; }

		public MaritalStatus MaritalStatus { get; set; }

		[RegularExpression(@"^(\d{11})$", ErrorMessage = "Invalid Number")]
		public string Mobile { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime UpdateDate { get; set; }

		public virtual Church Church { get; set; }

		public virtual Gender Gender { get; set; }
	}
}
