using System.Collections.Generic;
using System.Linq;
using relacionamento1nn1_api.Domain.Models;

namespace relacionamento1nn1_api.Domain.Repositories.Order
{
    public class OrderRepository : IOrderRepository
    {
        Context context;
        public OrderRepository(Context _context)
        {
            context = _context;
        }

        public IEnumerable<Orders> get()
        {
            var orders = context.Orders.ToList();
            return orders;
        }

        public Orders getById(int id)
        {
            var order = context.Orders.FirstOrDefault(x => x.OrderID == id);
            return order;
        }

        public bool post(Orders order)
        {
            context.Orders.Add(order);
            var result = context.SaveChanges();
            
            if(result > 0) return true;
            else return false;
        }
    }
}