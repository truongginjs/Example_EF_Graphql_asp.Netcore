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
            Field(x => x.Id, type: typeof(IdGraphType)).Description("Id of the UserProfile");
            Field(o => o.Name);
            Field(o => o.Detail);
            Field(o => o.Deleted);
        }
    }
}
