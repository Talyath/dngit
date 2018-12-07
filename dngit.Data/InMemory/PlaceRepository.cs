using dngit.Core.Data;
using dngit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dngit.Data.InMemory
{
    class PlaceRepository : IPlaceRepository
    {
        List<Place> Places = new List<Place>
        {
            new Place(){ Id = 1, Name = "Wagamamas", Description = "asian food", Founded = new DateTime(), Location = " here", Owner = "bob" },
            new Place(){ Id = 2, Name = "TGI", Description = "asian food", Founded = new DateTime(), Location = " here", Owner = "bob" },
            new Place(){ Id = 3, Name = "FNB", Description = "asian food", Founded = new DateTime(), Location = " here", Owner = "bob" },
            new Place(){ Id = 4, Name = "MC D", Description = "asian food", Founded = new DateTime(), Location = " here", Owner = "bob" },
            new Place(){ Id = 5, Name = "Burger King", Description = "asian food", Founded = new DateTime(), Location = " here", Owner = "bob" },
            new Place(){ Id = 6, Name = "KFC", Description = "asian food", Founded = new DateTime(), Location = " here", Owner = "bob" }

        };

        
        public Task<Place> Get(int id)
        {
            return Task.FromResult(Places.FirstOrDefault(p => p.Id == id));
        }

        public Task<List<Place>> All()
        {
            return Task.FromResult(Places);
        }

         
    }
}
