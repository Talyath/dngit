using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class RatingInputType : InputObjectGraphType
    {
        public RatingInputType()
        {
            Name = "RatingInput";
            Field<NonNullGraphType<IntGraphType>>("placeId");
            Field<NonNullGraphType<IntGraphType>>("Type");
            Field<NonNullGraphType<FloatGraphType>>("value");
        }
    }
}
