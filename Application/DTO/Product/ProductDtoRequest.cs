using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Product
{
    public class ProductDtoRequest
    {
        public ProductDtoRequest(string name, string description, string barcode, int id)
        {
            Name = name;
            Description = description ?? string.Empty;
            Barcode = barcode;
            Id = id;
        }

        public int Id { get; }
        [Required]
        public string Name { get; }

        public string Description { get; }
        public string? Barcode { get; }
    }
}
