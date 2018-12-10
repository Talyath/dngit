using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class PlaceInputType : InputObjectGraphType
    {
        public PlaceInputType()
        {
            Name = "PlaceInput";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("description");
            Field<NonNullGraphType<StringGraphType>>("location");
            Field<DateGraphType>("founded");
            Field<StringGraphType>("owner");
        }
    }
}
