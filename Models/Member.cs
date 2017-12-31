using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class Member : Person
	{
		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime? MemberSince { get; set; }

	}
}
