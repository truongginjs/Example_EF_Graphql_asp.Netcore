using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Example_EF_graphql_asp.NET.Models
{
    public class Product: BaseModel
    {
        [Required]
        public long Cost { get; set; }
        [ForeignKey("CategoryId")]
        [Required]
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
