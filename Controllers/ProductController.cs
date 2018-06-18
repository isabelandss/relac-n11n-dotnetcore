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

        [HttpGet]
        public IEnumerable<Products> get() {
            return context.Products.ToList();
        }
    }
}