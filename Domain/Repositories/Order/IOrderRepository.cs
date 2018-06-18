using System.Collections.Generic;
using relacionamento1nn1_api.Domain.Models;

namespace relacionamento1nn1_api.Domain.Repositories.Order
{
    public interface IOrderRepository
    {
        IEnumerable<Orders> get();
        Orders getById(int id);
        bool post(Orders order);
    }
}