using Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Mapster;
using System.Text.Json.Serialization;
using Domain.Entities;

namespace Application.DTO.Product
{
    public class ProductDtoResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        [JsonIgnore]
        public string Description { get; set; } = null!;
        public string Barcode { get; set; } = string.Empty;
        public int Quantity { get; set; }
        //public string CreatedOn { get; set; } = string.Empty;
        //[JsonPropertyName("storage_box")] 
        //public List<int> QuantityList  { get; set; } = new();

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
        public List<Cell> Cells { get; set; }

    }

    public class Cell
    {
        public string Name { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        public int Quantity { get; set; }
    }
}
