using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Entities
{
	public class Artist : IdentityBase
	{
		public Artist()
		{
			this.Products = new HashSet<Product>();
		}

		[Required]
		[DisplayName("Nombre")]
		public string FirstName { get; set; }

		[Required]
		[DisplayName("Apellido")]
		public string LastName { get; set; }

		public string LifeSpan { get; set; }


		[Required]
		[DisplayName("Pais")]
		public string Country { get; set; }

		public string Description { get; set; }


		[Required]
		[DisplayName("Cuadros")]
		public int TotalProducts { get; set; }

		public virtual ICollection<Product> Products { get; set; }
	}
}