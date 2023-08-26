using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Application.DTO.Document
{
    public class DocumentHeaderDto
    {
        // номер документа
        [JsonPropertyName("document_number")]
        public int DocumentNumber { get; set; }
        public DateTime DateTime { get; set; }
        // количество полей в документе
        public int FieldsQuality { get; set; }

        // Поставщик, продавец или провайдер
        public string Supplier { get; set; } = string.Empty;

        // Общая сумма, без копеек
        public int TotalPrice { get; set; }
    }
}
