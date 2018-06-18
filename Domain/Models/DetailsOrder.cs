using System;
using System.ComponentModel.DataAnnotations;

namespace relacionamento1nn1_api.Domain.Models
{
    public class DetailsOrder
    {
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 Quantity { get; set; }
        public Single Discount { get; set; }
    }
}