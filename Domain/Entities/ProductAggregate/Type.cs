using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities.ProductAggregate
{
    //ValueObject
    
    [Owned]
    public class Type
    {
        [Column("Type")]
        public string Name { get; set; } = string.Empty;
    }
}
