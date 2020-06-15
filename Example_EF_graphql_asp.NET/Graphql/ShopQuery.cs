using Example_EF_graphql_asp.NET.Data;
using Example_EF_graphql_asp.NET.Models;
using GraphQL.Types;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Linq;

namespace Example_EF_graphql_asp.NET.Graphql
{
    internal class ShopQuery : ObjectGraphType
    {
        public ShopQuery(DataContext dataContext)
        {
            Name = "Query";

            // Khai báo các hàm liên quan đến GET ở đây
            Field<ListGraphType<CategoryType>>("categories", resolve: context => dataContext.Category.ToListAsync());

            Field<ListGraphType<ProductType>>("products", resolve: context =>
            {
                return dataContext.Product.Include(p => p.Category);
            });

            FieldAsync<CategoryType>(
            "categoryById",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "categoryId" }),
            resolve: async context => {
                return await context.TryAsyncResolve(
                    async con => await dataContext.Category.FindAsync(con.GetArgument<Guid>("categoryId"))
                );
            }
            );
            FieldAsync<ProductType>(
            "productById",
            arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "productId" }),
            resolve: async context => {
                return await context.TryAsyncResolve(
                    async con =>
                    {
                        var pId = con.GetArgument<Guid>("categoryId");
                        var result = dataContext.Product.Where(p => p.Id == pId).Include(p => p.Category).FirstOrDefaultAsync();
                        return await result;
                    }
                ) ;
            }
            );
        }
    }
}