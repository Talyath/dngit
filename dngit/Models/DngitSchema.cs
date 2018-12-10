using GraphQL.Types;
using GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dngit.Models
{
    public class DngitSchema : Schema
    {
        public DngitSchema(IDependencyResolver resolver):base(resolver)
        {
            Query = resolver.Resolve<DngitQuery>();
            Mutation = resolver.Resolve<DngitMutation>();
        }

    }
}
