using System;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class ChurchStatus : Status
	{
		//public int Id { get; set; }

		//Indicate if fully chartered or not full fledged church
		[Required, Display(Name = "Church Status")]
		public string Name { get; set; }

		[Required, Display(Name = "Church Status Description")]
		public string Description { get; set; }

	}
}
