using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Entities
{
    public class Order : IdentityBase
    {
        public Order()
        {
            this.OrderItems = new HashSet<OrderDetail>();
        }

        [Required]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }
        
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public double TotalPrice { get; set; }
        [Required]
        public int OrderNumber { get; set; }
        [Required]
        public int ItemCount { get; set; }

        public virtual ICollection<OrderDetail> OrderItems { get; set; }

    }
}
