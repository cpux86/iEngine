
using Api.Wrappers;
using Application.DTO;
using Application.DTO.Product;
using Application.Interfaces;
using Domain.Entities;
using Domain.Entities.ProductAggregate;
using IronBarCode;
using Mapster;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{

    [ApiController]
    //[Route("[controller]")]
    [Route("product")]
    public class ProductController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductController(IProductServices productServices)
        {
            _productServices = productServices;
        }
        // Получить содержимое ячейки
        /* Клиенту должен отправится Json, содержащий Box и Product, а клиент сам примет решение как и в какой последовательности представить их пользователю
         *
         */
        // GetContentCell 
        // GetCellContent 

        /// <summary>
        /// Создать карточку товара
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("card")]
        public async Task CreateProductCardAsync([FromBody] CardRequest cardRequest)
        {
            await _productServices.AddCardAsync(cardRequest);
        }



        // Получить список товара из заданной корзины, ящика
        [HttpGet]
        [Route("filter")]
        public async Task<Response<List<ProductDtoResponse>>> GetProductsByBoxIdAsync(int start, int count)
        {

            //var myBarcode = BarcodeWriter.CreateBarcode("E-01-01-01-1.1", BarcodeWriterEncoding.Code128);
            ////myBarcode.AddBarcodeValueTextAboveBarcode();
            //myBarcode.AddBarcodeValueTextBelowBarcode();
            //myBarcode.ResizeTo(800, 200);
            //myBarcode.SaveAsImage("myBarcodeResized.jpeg");

            //var products = await _productServices.GetProductListAsync();
            //return new Response<List<ProductDtoResponse>>(products);

            var productList = await _productServices.GetProductListAsync();
            return new Response<List<ProductDtoResponse>>(productList);


        }



        ///// <summary>
        ///// Получить список товаров
        ///// </summary>
        ///// <param name="start"></param>
        ///// <param name="count"></param>
        ///// <returns></returns>
        //[HttpGet]
        //[Route("list")]
        //public async Task<Response<List<ProductDtoResponse>>> GetList(int start, int count)
        //{

        //    //var myBarcode = BarcodeWriter.CreateBarcode("E-01-01-01-1.1", BarcodeWriterEncoding.Code128);
        //    ////myBarcode.AddBarcodeValueTextAboveBarcode();
        //    //myBarcode.AddBarcodeValueTextBelowBarcode();
        //    //myBarcode.ResizeTo(800, 200);
        //    //myBarcode.SaveAsImage("myBarcodeResized.jpeg");

        //    //var products = await _productServices.GetProductListAsync();
        //    //return new Response<List<ProductDtoResponse>>(products);

        //    var productList = await _productServices.GetStockProductListAsync();
        //    return new Response<List<ProductDtoResponse>>(productList);


        //}





        /// <summary>
        /// Получить товар по его ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{id}/details")]
        public async Task<Response<ProductDtoResponse>> GetProduct([FromRoute]int id)
        {
           var product = await _productServices.GetProductAsync(id);
           var result = new Response<ProductDtoResponse>(product);
           return result;
        }

        [HttpPost]
        [Route("upload")]
        public async Task AddProductsAsync([FromBody] CreateProductDto productDto)
        {
            await _productServices.AddProductToCardAsync(productDto);
        }

        //[HttpPost]
        //[Route("update/quantity")]
        //public async Task<Product> UpdateQuantityAsync([FromBody] ProductQuantityRequest quantity)
        //{
        //    var product = await _productServices.UpdateQuantityAsync(quantity);
        //    return product;
        //}



        [HttpPost]
        //[Route("{id}")]
        [Route("update")]
        public async Task EditProductAsync([FromBody] List<ProductDtoRequest> product)
        {
            await _productServices.UpdateAsync(product);
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<Response<bool>> DeleteProductByIdAsync([FromRoute]int id)
        {
            await _productServices.DeleteAsync(id);
            return new Response<bool>(true);
        }
    }
}
