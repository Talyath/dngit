using dngit.Core.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class RatingType : ObjectGraphType<Rating>
    {
        public RatingType()
        {
            Field(x => x.Id);
            Field<StringGraphType>("type", resolve: context => ((RatingTypes)context.Source.Type).ToString() );
            Field(x => x.Value);
        }
    }
}
