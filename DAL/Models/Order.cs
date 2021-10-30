using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        public int? ProductId { get; set; }
        public decimal? OrderValue { get; set; }
        public string OtherDetails { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipCountry { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? PostalCode { get; set; }
        public string State { get; set; }
        public string OrderDate { get; set; }
        public DateTime? DateModified { get; set; }
        public DateTime? DateRemoved { get; set; }
        public int? PaymentStatus { get; set; }
    }
}
