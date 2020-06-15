using Example_EF_graphql_asp.NET.Models;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Graphql
{
    public class CategoryType : ObjectGraphType<Category>
    {
        public CategoryType()
        {
            Field(o => o.Id);
            Field(o => o.Name);
            Field(o => o.Detail);
            Field(o => o.Deleted);
        }
    }
}
