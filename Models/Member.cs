using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class Member
	{
		public int MemberId { get; set; }

        //[Required, Display(Name = "First Name")]
        //[StringLength(30, ErrorMessage = "Limit first name to 30 characters.")]
        public string FirstName { get; set; }

        //[Required, Display(Name = "Last Name")]
        //[StringLength(30, ErrorMessage = "Limit last name to 30 characters.")]
        //public string LastName { get; set; }

        ////[Required]
        //public string Address { get; set; }

        //[Required]
        //public DateTime DateOfBirth { get; set; }
        //public string Telephone { get; set; }
        //public string Gender { get; set; }

        //[Required, Display(Name = "Library Card")]
        //public virtual userName UserName { get; set; }

	}
}
