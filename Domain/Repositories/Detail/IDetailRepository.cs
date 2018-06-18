using System.Collections.Generic;
using relacionamento1nn1_api.Domain.Models;

namespace relacionamento1nn1_api.Domain.Repositories.Detail
{
    public interface IDetailRepository
    {
        IEnumerable<DetailsOrder> get();
        IList<DetailsOrder> getById(int id);
        bool post(DetailsOrder details);
    }
}