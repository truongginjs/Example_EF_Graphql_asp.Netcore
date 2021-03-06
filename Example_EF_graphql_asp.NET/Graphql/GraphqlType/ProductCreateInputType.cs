﻿using GraphQL.Types;
using System;

namespace Example_EF_graphql_asp.NET.Graphql
{
    internal class ProductCreateInputType : InputObjectGraphType
    {
        public ProductCreateInputType()
        {
            Name = "ProductCreateInputType";
            Field<NonNullGraphType<StringGraphType>>("name");
            Field<StringGraphType>("detail");
            Field<NonNullGraphType<IntGraphType>>("cost");
            Field<NonNullGraphType<IdGraphType>>("categoryId");
        }
    }
}