using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.ProductAggregate;
using Microsoft.EntityFrameworkCore;

namespace Domain.Entities
{
    public class Warehouse : BaseEntity
    {
        public Warehouse(string name)
        {
            Name = name;
        }
        /// <summary>
        /// Наименование склада. К примеру Склад #27
        /// </summary>
        public string Name { get; set; }
        // Стеллажи склада
        public List<Rack> Racks { get; set; }

        //public List<Box> Boxes { get; set; } = null!;

    }
}
 