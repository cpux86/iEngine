using Application.DTO.Document;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentServices _documentServices;

        public DocumentController(IDocumentServices documentServices)
        {
            _documentServices = documentServices;
        }

        [HttpPost]
        public async Task<int> AddDocumentAsync(DocumentDto document)
        {
            return await _documentServices.AddFullDocumentAsync(document);
        }
    }
}
