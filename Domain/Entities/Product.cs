using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Domain.Entities.ProductAggregate;

namespace Domain.Entities
{
    // На каждую операцию поступления товара на склад составляется новый Product 
    public class Product : BaseEntity
    {
        //public string Name { get; set; } = string.Empty;
        //// для внутреннего использования присваивается |уникальный| код товару (штрих-код)  
        //// SKU - уникальный код товара внутри компании. 
        public string Barcode { get; set; } = string.Empty;

        //public int CardId { get; set; }
        public Card? Card { get; set; } = new();

        public int Quantity { get;  set; } = 0;

        
        public Box? Box { get; set; }


        // Дата создания записи
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        // Дата последнего изменения
        public DateTime? ModifiedOn { get; set; } = DateTime.Now;

        public void AddQuantity(int quantity)
        {
            this.Quantity += quantity;
        }
    }
}
