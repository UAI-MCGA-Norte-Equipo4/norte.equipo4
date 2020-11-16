using System;

namespace ArtMarket.Entities.Model
{
    [Serializable]
    public partial class OrderDetail : IdentityBase
    {
        public double Price { get; set; }
        public int Quantity { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}