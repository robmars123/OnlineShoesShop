using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class CartItem
    {
        public int CartItemId { get; set; }
        public int CartId { get; set; }
        public string UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public int PaymentStatus { get; set; }
    }
}
