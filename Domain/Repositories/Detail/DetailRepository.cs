using System.Collections.Generic;
using System.Linq;
using relacionamento1nn1_api.Domain.Models;

namespace relacionamento1nn1_api.Domain.Repositories.Detail
{
    public class DetailRepository : IDetailRepository
    {
        Context context;
        public DetailRepository(Context _context)
        {
            context = _context;
        }

        public IEnumerable<DetailsOrder> get()
        {
            return context.DetailsOrder.ToList();
        }

        public IList<DetailsOrder> getById(int id)
        {
            return context.DetailsOrder.Where(x => x.OrderID == id).ToList();
        }

        public bool post(DetailsOrder details)
        {
            context.DetailsOrder.Add(details);
            var result = context.SaveChanges();
            
            if(result > 0) return true;
            else return false;
        }
    }
}