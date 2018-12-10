using dngit.Core.Data;
using dngit.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dngit.Data.Repository
{
    public class RatingRepository : IRatingRepository
    {
        private readonly DngitContext _db;
        public RatingRepository(DngitContext db)
        {
            _db = db;
        }
        public async Task<Rating> Add(Rating rating)
        {

            await _db.Ratings.AddAsync(rating);
            await _db.SaveChangesAsync();
            return rating;
        }

        public Task<List<Rating>> AllAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<Rating> Get(int id)
        {
            return await _db.Ratings.FirstOrDefaultAsync(r => r.Id == id);
        }

        public async Task<List<Rating>> GetPlaceRatings(int id)
        {
            return await _db.Ratings.Where(r => r.PlaceId == id).ToListAsync();
        }
    }
}
