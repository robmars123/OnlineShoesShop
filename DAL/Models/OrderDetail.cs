using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class OrderDetail
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public decimal? Discount { get; set; }
        public int? Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
    }
}
