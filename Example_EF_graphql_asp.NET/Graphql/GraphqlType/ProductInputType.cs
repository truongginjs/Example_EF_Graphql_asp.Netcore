using GraphQL.Types;
using System;

namespace Example_EF_graphql_asp.NET.Graphql
{
    internal class ProductInputType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public long Cost { get; set; }
        public Guid CategoryId { get; set; }
    }
}