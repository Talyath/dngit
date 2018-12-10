using dngit.Core.Data;
using dngit.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dngit.Data.InMemory
{
    public class PlaceRepository : IPlaceRepository
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

        public Task<List<Place>> AllAsync()
        {
            return Task.FromResult(Places);
        }

        public Task<Place> Add(Place place)
        {
            var _newPlace = new Place()
            {
                Id = 1111,
                Name = place.Name,
                Description = place.Description,
                Founded = place.Founded,
                Location = place.Location,
                Owner = place.Owner,
            };
            Places.Add(_newPlace);
            return Task.FromResult(_newPlace);
        }

         
    }
}
