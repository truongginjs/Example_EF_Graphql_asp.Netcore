using Example_EF_graphql_asp.NET.Data;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using System;

namespace Example_EF_graphql_asp.NET.Graphql
{
    internal class ShopQuery : ObjectGraphType
    {
        public ShopQuery(DataContext dataContext)
        {
            Name = "Query";

            // Khai báo các hàm liên quan đến GET ở đây
            Field<ListGraphType<CategoryType>>("categories", resolve: context => dataContext.Category.ToListAsync());
            Field<ListGraphType<ProductType>>("products", resolve: context => dataContext.Product.ToListAsync());
            FieldAsync<CategoryType>(
            "categoryById",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "categoryId" }),
            resolve: async context => {
                return await context.TryAsyncResolve(
                    async c => await dataContext.Category.FindAsync(c.GetArgument<Guid>("categoryId"))
                );
            }
            );
            FieldAsync<ProductType>(
            "productById",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<GuidGraphType>> { Name = "productId" }),
            resolve: async context => {
                return await context.TryAsyncResolve(
                    async c => await dataContext.Product.FindAsync(c.GetArgument<Guid>("productId"))
                );
            }
            );
        }
    }
}