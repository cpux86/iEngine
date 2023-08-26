using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Application.DTO.Document
{
    public class DocumentDto : DocumentHeaderDto
    {
        public List<DocumentFieldDto> Rows { get; set; } = null!;
    }
}
