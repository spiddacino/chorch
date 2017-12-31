using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class ChurchBD1
	{
		public int Id { get; set; }

		[Required, Display(Name = "ChurchBD1 Name")]
		public string Name { get; set; }

		//public Church ChurchBD1Head { get; set; }

		//public virtual IEnumerable<Church> Churches { get; set; }

	}
}
