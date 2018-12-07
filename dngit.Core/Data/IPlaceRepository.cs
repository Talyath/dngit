using dngit.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dngit.Core.Data
{
    public interface IPlaceRepository
    {
        Task<Place> Get(int id);
        Task<List<Place>> All();

    }
}
