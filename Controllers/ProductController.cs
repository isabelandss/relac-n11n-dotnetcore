using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using relacionamento1nn1_api.Domain.Models;

namespace relacionamento1nn1_api.Controllers
{
    [Route("api/[controller]")]
    public class ProductController
    {
        Context context;
        public ProductController(Context _context)
        {
            context = _context;
        }

        /// <summary>
        /// Transforma uma temperatura em Fahrenheit para o equivalente
        /// nas escalas Celsius e Kelvin.
        /// </summary>
        /// <returns>Objeto contendo valores para uma temperatura
        /// nas escalas Fahrenheit, Celsius e Kelvin.</returns>
        [HttpGet]
        public IEnumerable<Products> get() {
            return context.Products.ToList();
        }
    }
}