using Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    /* Боксом может быть как ящик размещенный в ячейке стеллажа, также паллет с коробками
     * в которых также могут быть товары со штрихкодом 
     *
     *
     */
    public class Box
    {
        public Box(string barcode)
        {
            Barcode = barcode;
        }
        public Box(string barcode, string name)
        {
            Barcode = barcode;
            Name = name;
        }

        public int Id { get; set; }
        // Склад 27, Шкаф 1
        public string Name { get; set; } = null!;
        // Что там. К пример "Провода компьютерные".
        public string? Comment { get; set; }
        // склад, стеллаж, шкаф, ящик, коробка.
        public string BoxType { get; set; }
        public string Barcode { get; set; }
        //public virtual List<Box> Boxes { get; set; } = new();

        [JsonIgnore]
        public List<Product> Products { get; set; } = new();

        


        //#region Tree


        //public int? ParentId { get; set; }
        //public virtual Box? Parent { get; set; }
        //public int Level { get; set; }
        //public int LeftKey { get; set; }
        //public int RightKey { get; set; }

        //#endregion
    }
}
