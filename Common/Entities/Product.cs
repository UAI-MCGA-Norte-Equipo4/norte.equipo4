using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
	public class Product : IdentityBase
	{
		[Required]
		[DisplayName("Nombre")]
		public string Title { get; set; }

		[Required]
		[DisplayName("Descripción")]
		public string Description { get; set; }
		public int ArtistId { get; set; }
		public string Image { get; set; }


		[Required]
		[DisplayName("Valor")]
		public double Price { get; set; }
		public int QuantitySold { get; set; }
		public double AvgStars { get; set; }

		public virtual Artist Artist { get; set; }
	}
}
