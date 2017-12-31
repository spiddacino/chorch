using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class ChurchBD2
	{
		public int Id { get; set; }

		[Required, Display(Name = "ChurchBD2 Name")]
		public string Name { get; set; }

		//public Church ChurchBD2Head { get; set; }

		//public virtual IEnumerable<ChurchBD1> Churches { get; set; }

	}
}
