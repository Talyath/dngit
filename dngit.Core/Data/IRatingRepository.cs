using dngit.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dngit.Core.Data
{
    public interface IRatingRepository
    {
        Task<Rating> Get(int id);
        Task<List<Rating>> AllAsync();
        Task<Rating> Add(Rating place);
        Task<List<Rating>> GetPlaceRatings(int id);
    }
}
