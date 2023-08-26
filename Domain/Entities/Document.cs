using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Document : BaseEntity
    {

        // номер документа
        public int DocumentNumber { get; set; }
        public DateTime DateTime { get; set; }
        // количество полей в документе
        public int FieldsQuality { get; set; }
        //public List<Product> Rows { get; set; } = new List<Product>();

        // Поставщик, продавец или провайдер
        public string Supplier { get; set; } = string.Empty;

        // Общая сумма, без копеек
        public int TotalPrice { get; set; }

        public void AddField(Product field)
        {
            //this.Orders.Add(field);
        }
    }
}
