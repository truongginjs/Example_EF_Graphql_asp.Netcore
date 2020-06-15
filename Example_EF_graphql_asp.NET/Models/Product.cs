using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Models
{
    public class Product: BaseModel
    {
        [Required]
        public long Cost { get; set; }
        [Required]
        public Category Category { get; set; }
    }
}
