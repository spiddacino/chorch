using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class Region
	{
		public int Id { get; set; }

		[Required, Display(Name = "Region Name")]
		public string Name { get; set; }

		public Church RegionHQ { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime CreatedDate { get; set; }

		public virtual IEnumerable<District> Districts { get; set; }

	}
}
