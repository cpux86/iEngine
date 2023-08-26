using Application.DTO.Product;
using Domain.Entities.ProductAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Application.DTO;

namespace Application.Interfaces
{
    public interface IProductServices
    {
        public Task<List<ProductDtoResponse>> GetProductListAsync();
        public Task AddCardAsync(CardRequest cardRequest);

        //public Task<List<ProductDtoResponse>> GetStockProductListAsync();
        //public Task<Product> UpdateQuantityAsync(ProductQuantityRequest quantity);
        //public Task<List<Product>> AddProductsAsync(List<CreateProductDto> productDto);


        public Task AddProductToCardAsync(CreateProductDto productDto);

        public Task<ProductDtoResponse> GetProductAsync(int id);
        public Task UpdateAsync(List<ProductDtoRequest> productDto);
        public Task DeleteAsync(int id);
    }
}
