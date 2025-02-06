// Dosya: Ecommerce.Domain.Entities/Product.cs
using System;

namespace Ecommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
       
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
    }
}
