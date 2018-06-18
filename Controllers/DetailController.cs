using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using relacionamento1nn1_api.Domain.Models;

namespace relacionamento1nn1_api.Controllers
{
    [Route("api/[controller]")]
    public class DetailController
    {
        Context context;

        public DetailController(Context _context)
        {
            context = _context;
        }
        
        [HttpGet]
        public IEnumerable<DetailsOrder> get() {
            return context.DetailsOrder.ToList();
        }
    }
}