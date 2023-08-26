using Application.DTO.Product;
using Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    [Route("storage")]
    public class StorageController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public StorageController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpPost]
        [Route("upload")]
        public async Task AddInBoxAsync([FromBody] AddProductInBox addProduct)
        {
            //await _productServices.
        }
    }
}
