using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ProductAggregate
{
    public class ProductPropery
    {
        public int Id { get; set; }

        //public Product Product { get; set; } = new();

        public Property Property { get; set; } = new();
        public string Value { get; set; } = string.Empty;
    }
}
