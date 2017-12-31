using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chorch.Models
{
	public class District
	{
		public int Id { get; set; }

		[Required, Display(Name = "District Name")]
		public string Name { get; set; }

		public virtual Church DistrictHQ { get; set; }

		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
		public DateTime CreatedDate { get; set; }

		public virtual IEnumerable<Church> Churches { get; set; }

	}
}
