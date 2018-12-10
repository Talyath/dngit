using dngit.Core.Models;
using dngit.Core.Data;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class PlaceType : ObjectGraphType<Place>
    {
        public PlaceType(IRatingRepository ratingRepository)
        {
            Field(x => x.Id);
            Field(x => x.Name);
            Field(x => x.Description, true);
            Field(x => x.Location);
            Field(x => x.Founded, true);
            Field(x => x.Owner, true);
            Field<ListGraphType<RatingType>>("ratings",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => ratingRepository.GetPlaceRatings(context.Source.Id), description: "Place's Ratings");
                
        }
    }
}
