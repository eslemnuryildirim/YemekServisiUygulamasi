// Dosya: Ecommerce.Domain.Entities/Order.cs
using System;
using System.Collections.Generic;

namespace Ecommerce.Domain.Entities
{
    public class Order : BaseEntity
    {
        public DateTime OrderDate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
