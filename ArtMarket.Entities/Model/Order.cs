using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ArtMarket.Entities.Model
{
    [Serializable]
    [DataContract]
    public partial class Order : IdentityBase
    {
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        public int OrderNumber { get; set; }
        public int ItemCount { get; set; }
        public int UserId { get; set; }

        public virtual ICollection<OrderDetail> OrderDetail { get; set; } = new HashSet<OrderDetail>();

        //[DataMember]
        public virtual User User { get; set; }
    }
}