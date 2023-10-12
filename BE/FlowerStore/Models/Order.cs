using System;
using System.Collections.Generic;

namespace FlowerStore.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public int OrderId { get; set; }
        public DateTime? OderDate { get; set; }
        public int? TotalQuantity { get; set; }
        public double? TotalPrice { get; set; }
        public string? NameCusNonAccount { get; set; }
        public string? PhoneCusNonAccount { get; set; }
        public string? AddressCusNonAccount { get; set; }
        public int? CustomerId { get; set; }
        public int? OrderStatusId { get; set; }
        public int? OrderMethodId { get; set; }
        public int? StoreId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual OrderMethod? OrderMethod { get; set; }
        public virtual OrderStatus? OrderStatus { get; set; }
        public virtual Store? Store { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
