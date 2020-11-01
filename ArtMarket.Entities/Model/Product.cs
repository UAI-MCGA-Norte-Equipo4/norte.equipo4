using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ArtMarket.Entities.Model
{
    [Serializable]
    public partial class Product : IdentityBase
    {
        public Product()
        {
            this.CartItem = new HashSet<CartItem>();
            this.OrderDetail = new HashSet<OrderDetail>();
            this.Rating = new HashSet<Rating>();
        }

        [Required]
        [DisplayName("Nombre")]
        public string Title { get; set; }

        [Required]
        [DisplayName("Descripción")]
        public string Description { get; set; }

        public string Image { get; set; }

        [Required]
        [DisplayName("Precio")]
        public double Price { get; set; }

        public int QuantitySold { get; set; }

        public double AvgStars { get; set; }
        public int ArtistId { get; set; }

        public virtual Artist Artist { get; set; }
        public virtual ICollection<CartItem> CartItem { get; set; }
        public virtual ICollection<OrderDetail> OrderDetail { get; set; }
        public virtual ICollection<Rating> Rating { get; set; }
    }
}