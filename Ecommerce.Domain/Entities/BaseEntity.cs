// Dosya: Ecommerce.Domain.Entities/BaseEntity.cs
using System;

namespace Ecommerce.Domain.Entities
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
