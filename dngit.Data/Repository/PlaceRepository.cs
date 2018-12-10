using dngit.Core.Data;
using dngit.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace dngit.Data.Repository
{
    public class PlaceRepository : IPlaceRepository
    {
        private readonly DngitContext _db;
        public PlaceRepository(DngitContext db)
        {
            _db = db;
        }

        public async Task<Place> Add(Place place)
        {
            await _db.Places.AddAsync(place);
            await _db.SaveChangesAsync();
            return place;
        }

        public async Task<List<Place>> AllAsync()
        {
            return await _db.Places.ToListAsync();
        }

        public async Task<Place> Get(int id)
        {
            return await _db.Places.FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
