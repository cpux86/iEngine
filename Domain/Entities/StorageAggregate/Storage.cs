using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.StorageAggregate
{
    public abstract class Storage
    {   
        public int Id { get; set; }
        // Склад 27
        public string Name { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
    }
}
