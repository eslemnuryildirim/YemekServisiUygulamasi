using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces
{
    public interface IOrderService
    {
        Task CreateOrderAsync(Order order);
        Task<IEnumerable<Order>> GetAllOrdersAsync();

    }
}
