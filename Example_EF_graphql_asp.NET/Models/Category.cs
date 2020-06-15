using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Models
{
    public class Category: BaseModel
    {
        public List<Product> Products { get; set; }
    }
}
