using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Entities
{
	public class CartItem : IdentityBase
	{
		public int CartId { get; set; }

		public int ProductId { get; set; }

		[Required]
		[DisplayName("Total")]
		public double Price { get; set; }

		[Required]
		[DisplayName("Cantidad")]
		public int Quantity { get; set; }

		public virtual Product Product { get; set; }

		public virtual Cart Cart { get; set; }

	}
}
