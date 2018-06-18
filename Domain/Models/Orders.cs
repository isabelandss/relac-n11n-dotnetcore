using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace relacionamento1nn1_api.Domain.Models
{
    public class Orders
    {
        [Key]
        public int OrderID { get; set; }

        [Required]
        public string CustomerID { get; set; }

        [Required]
        public int EmployeeID { get; set; }

        public DateTime OrderDate { get; set; }
        
        public DateTime? RequiredDate { get; set; }
        
        public DateTime? ShippedDate { get; set; }
        
        public int ShipVia { get; set; }
        
        public decimal Freight { get; set; }
        
        public string ShipName { get; set; }
        
        public string ShipAddress { get; set; }
        
        public string ShipCity { get; set; }
        
        public string ShipRegion { get; set; }
        
        public string ShipPostalCode { get; set; }
        
        public string ShipCountry { get; set; }

        public ICollection<DetailsOrder> DetailsOrder { get; set; }
        // public DetailsOrder DetailsOrder { get; set; }
    }
}