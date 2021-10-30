using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class ProductImage
    {
        public int ImageId { get; set; }
        public int ProductId { get; set; }
        public byte[] Image { get; set; }
    }
}
