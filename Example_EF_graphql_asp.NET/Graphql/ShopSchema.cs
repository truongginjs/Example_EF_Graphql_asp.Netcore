using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Graphql
{
    public class ShopSchema : Schema
    {
        public ShopSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<ShopQuery>();
            Mutation = resolver.Resolve<ShopMutation>();
        }
    }
}
