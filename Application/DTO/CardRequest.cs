﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class CardRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
    }
}
