using Example_EF_graphql_asp.NET.Data;
using Example_EF_graphql_asp.NET.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Graphql
{
    public class ProductType : ObjectGraphType<Product>
    {
        public ProductType(DataContext context)
        {
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the UserProfile");
            Field(x => x.Name);
            Field(x => x.Cost);
            Field(x => x.Detail);
            Field(x => x.Deleted);

            Field<CategoryType>(nameof(Category));

        }
    }
}
