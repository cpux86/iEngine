using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Barcode
    {
        public Guid Id { get; set; }
        //public string? Title { get; set; }
        public string Value { get; set; } = string.Empty;
    }
}
