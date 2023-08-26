using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.ProductAggregate
{
    /// <summary>
    /// Ячейка для хранения
    /// </summary>
    public class Cell
    {
        public int Id { get; set; }
        /// <summary>
        /// 01-01-01-1.1 [линия]-[стеллаж]-[уровень]-[номер ячейки]
        /// </summary>
        public string Text { get; set; } = string.Empty;
        
        public string Barcode { get; set; } = string.Empty;

        // Может быть ящик с товарами 
        public List<Box>? Boxes { get; set; }
        public List<Product>? Products { get; set; }


        ///// <summary>
        ///// Склад, зона, помещение в которой размещен стеллаж. К примеру склад E - Electronics
        ///// </summary>
        //public string Zone { get; set; } = string.Empty;
        ///// <summary>
        ///// Линия, когда стеллажи стоят в линию. E-01 
        ///// </summary>
        //public int Line { get; set; }
        ///// <summary>
        ///// Номер стеллажа. E-01-01
        ///// </summary>
        //public int Rack { get; set; }
        ///// <summary>
        ///// Уровень. 1-й это на полу. E-01-01-01
        ///// </summary>
        //public int Level { get; set; }

        ///// <summary>
        ///// Номер ячейки. E-01-01-01-1.1
        ///// </summary>
        //public string CellId { get; set; } = string.Empty;


    }
}
