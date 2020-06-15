using GraphQL.Types;

namespace Example_EF_graphql_asp.NET.Graphql
{
    internal class CategoryCreateInputType: InputObjectGraphType
    {
        public CategoryCreateInputType()
        {
            Name = "CategoryCreateInputType";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("detail");
        }
    }
}