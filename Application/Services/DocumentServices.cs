using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Document;
using Application.Interfaces;
using Domain.Entities;
using Mapster;
using Microsoft.EntityFrameworkCore;

namespace Application.Services
{
    public class DocumentServices : IDocumentServices
    {
        private readonly IStockDbContext _context;

        public DocumentServices(IStockDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddFullDocumentAsync(DocumentDto documentDto)
        {

            var document = documentDto.Adapt<Document>();

            _context.Documents.Add(document);
            await _context.SaveChangesAsync(CancellationToken.None);
            return document.Id;
        }

        public async Task<int> AddDocumentAsync(DocumentHeaderDto header)
        {
            var document = new Document
            {
                DocumentNumber = header.DocumentNumber,
                DateTime = header.DateTime,
                Supplier = header.Supplier,
                FieldsQuality = header.FieldsQuality,
                TotalPrice = header.TotalPrice
            };
            await _context.Documents.AddAsync(document, CancellationToken.None);
            return document.Id;
        }

        //public async Task<string> AddFieldByIdAsync(DocumentFieldDto fieldDto, int documentId)
        //{
        //    //var id = Guid.Parse(documentId);
        //    var document = await _context.Documents
        //                       .FirstOrDefaultAsync(d => d.Id == documentId, CancellationToken.None) ??
        //                   throw new Exception("документ не найден");

        //    var field = new Product
        //    {
        //        Name = fieldDto.Name,
        //        Quantity = fieldDto.Quantity,
        //        Price = fieldDto.Price
        //    };

        //    document.AddField(field);
        //    await _context.SaveChangesAsync(CancellationToken.None);
        //    return document.Id.ToString();
        //}
    }
}
