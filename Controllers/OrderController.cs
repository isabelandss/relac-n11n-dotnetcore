using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using relacionamento1nn1_api.Domain.Models;
using relacionamento1nn1_api.Domain.Repositories.Order;
using relacionamento1nn1_api.Domain.Repositories.Detail;

namespace relacionamento1nn1_api.Controllers
{
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        IOrderRepository orderRepository;
        IDetailRepository detailRepository;
        public OrderController(IOrderRepository _orderRepository, IDetailRepository _detailRepository)
        {
            orderRepository = _orderRepository;
            detailRepository = _detailRepository;
        }

        [HttpGet]
        public IActionResult get() {
            var orders = orderRepository.get();

            if(orders != null) {
                var details = detailRepository.get();

                foreach (var order in orders)
                {
                    var _details = details
                        .Where(x => x.OrderID == order.OrderID)
                        .ToList();
                    order.DetailsOrder = _details;
                }

                return Ok(orders);
            }

            return NotFound();
        }

        [HttpGet("{id}")]
        public IActionResult getById(int id) {
            var order = orderRepository.getById(id);

            if(order != null) {
                var details = detailRepository.getById(id);

                order.DetailsOrder = details;
                return Ok(order);
            }

            return NotFound();
        }
    }
}