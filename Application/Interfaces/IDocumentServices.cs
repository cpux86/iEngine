using Application.DTO.Document;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IDocumentServices
    {
        public Task<int> AddFullDocumentAsync(DocumentDto documentDto);
    }
}
