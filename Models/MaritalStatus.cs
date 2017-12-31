using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class MaritalStatus : Status
	{
		[Required]
		public string Name { get; set; }

		[Required]
		public string Description { get; set; }

	}
}
