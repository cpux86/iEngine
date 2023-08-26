using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Product
{
    public class CreateProductDto
    {
        //[Required]
        //public string Name { get; set; }
        public string Barcode { get; set; }

        public int Quantity { get; set; } = 1;
        public int BoxId { get; set; }

    }
}
