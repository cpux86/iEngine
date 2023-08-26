using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities.ProductAggregate
{
    // Карточка товара (Card). Должна быть общая для всех одинаковых товаров
    public class Card : BaseEntity
    {
        private string _name = string.Empty;
        private string _description = string.Empty;

        public string Name
        {
            get => _name;
            set => _name = value.Trim();
        }

        public string Description
        {
            get => _description;
            set => _description = value.Trim();
        }
        /// <summary>
        /// Штрих-код изготовителя. UPC - глобальный стандарт штрих-кодов
        /// </summary>
        public string Barcode { get; set; } = string.Empty;

        public List<Product>? Products { get; set; }


        // добавить продукт к карточке товара
        public void AddProduct(Product product)
        {
            this.Products?.Add(product);
        }


        // доступное количество на складе 
        //public int AvailableStock { get; set; }

        public int GetAvailableStock()
        {
            return this.Products.Sum(q => q.Quantity);
        }


        //public Status Status { get; set; } = Status.Unknown;

        /// <summary>
        /// Увеличивает количество этого товара на складе 
        /// </summary>
        /// <param name="quantity"></param>
        /// <returns></returns>
        //public int AddStock(int quantity)
        //{
        //    if (quantity <= 0) throw new Exception("не верное количество");
        //    this.
        //    AvailableStock += quantity;
        //    return quantity;
        //}

        /// <summary>
        /// Уменьшает количество этого товара на складе 
        /// </summary>
        /// <param name="quantityDesired"></param>
        /// <returns></returns>
        //public int RemoveStock(int quantityDesired)
        //{
        //    if (AvailableStock == 0) throw new Exception("товара нет в наличии");
        //    if (AvailableStock < quantityDesired) throw new Exception("не допустимое количество");
        //    AvailableStock -= quantityDesired;
        //    return quantityDesired;
        //}

    }
}