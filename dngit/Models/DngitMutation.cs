using dngit.Core.Data;
using dngit.Core.Models;
using dngit.Data.InMemory;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class DngitMutation : ObjectGraphType
    {
        public DngitMutation(IPlaceRepository placeRepository, IRatingRepository ratingRepository)
        {
            Field<PlaceType>(
                "createPlace",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<PlaceInputType>> { Name = "place" }
                    ),
                resolve: context =>
                {
                    var place = context.GetArgument<Place>("place");
                    return placeRepository.Add(place);
                });

            Field<RatingType>(
                "addRating",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<RatingInputType>> { Name = "rating" }
                    ),
                resolve: context =>
                {
                    var rating = context.GetArgument<Rating>("rating");
                    return ratingRepository.Add(rating);
                });
        }
        
    
    }
}
