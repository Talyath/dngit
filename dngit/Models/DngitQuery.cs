using dngit.Core.Data;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class DngitQuery : ObjectGraphType
    {
        public DngitQuery(IPlaceRepository placeRepository)
        {
            Field<PlaceType>(
                "place",
                arguments: new QueryArguments(new QueryArgument<IntGraphType> { Name = "id" }),
                resolve: context => placeRepository.Get(context.GetArgument<int>("id")));
            
            Field<ListGraphType<PlaceType>>(
                "places",
                resolve: context => placeRepository.All());
        }
    }
}
