using dngit.Core.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class PlaceType : ObjectGraphType<Place>
    {
        public PlaceType()
        {
            Field(x => x.Id);
            Field(x => x.Name, true);
            Field(x => x.Location);
            Field(x => x.Founded);
            Field(x => x.Owner);
        }
    }
}
