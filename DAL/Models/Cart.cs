using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Cart
    {
        public int CartId { get; set; }
        public int? ProductId { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? Quantity { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public int? Status { get; set; }
        public string UserId { get; set; }
    }
}
