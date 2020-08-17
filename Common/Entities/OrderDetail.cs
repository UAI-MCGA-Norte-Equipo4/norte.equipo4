using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Entities
{
    public class OrderDetail : IdentityBase
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
  }
}
