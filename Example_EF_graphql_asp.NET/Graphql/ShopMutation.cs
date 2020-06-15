using Example_EF_graphql_asp.NET.Data;
using Example_EF_graphql_asp.NET.Models;
using GraphQL.Types;

namespace Example_EF_graphql_asp.NET.Graphql
{
    internal class ShopMutation : ObjectGraphType
    {
        public ShopMutation(DataContext dataContext)
        {
            Name = "Mutation";
            // Khai báo các hàm liên quan đến POST, PUT, PATCH, DELETE ở đây
            FieldAsync<CategoryType>(
                "createCategory",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<CategoryCreateInputType>> { Name = "category" }),
                resolve: async context => 
                {
                    var categoryInput = context.GetArgument<Category>("category");
                    //var category = new Category
                    //{
                    //    Name = categoryInput.Name,
                    //    Detail=categoryInput.Detail,
                        
                    //};
                    return await dataContext.Category.AddAsync(categoryInput);
                }
            );


            FieldAsync<ProductType>(
                "CreateProduct",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<ProductCreateInputType>> { Name = "product" }),
                resolve: async context =>
                {
                    var productInput = context.GetArgument<Product>("product");
                    return await dataContext.Product.AddAsync(productInput);    
                
                }
            );


        }
    }
}