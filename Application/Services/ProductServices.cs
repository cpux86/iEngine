using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Product;
using Application.Interfaces;
using Domain.Entities;
using Domain.Entities.ProductAggregate;
using Mapster;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.AccessControl;
using Application.Common.Exceptions;
using MapsterMapper;
using Application.DTO;
using Cell = Application.DTO.Product.Cell;

namespace Application.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IStockDbContext _context;
        private readonly IMapper _mapper;

        public ProductServices(IStockDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<ProductDtoResponse>> GetProductListAsync()
        {
            var test = await _context.Cards.FirstOrDefaultAsync(CancellationToken.None);
            var product = await _context.Cards
                .Include(p => p.Products)
                .Select(e => new ProductDtoResponse
                {
                    Id = e.Id,
                    Name = e.Name,
                    Barcode = e.Barcode,
                    Quantity = e.Products!.Sum(t => t.Quantity),
                    //QuantityList = e.Products!.Select( q=>q.Quantity).ToList(),
                    Cells = e.Products!.Select(c=> new Cell
                    {
                        Name = c.Box!.Name,
                        Barcode = c.Box.Barcode,
                        Quantity = c.Quantity
                    }).ToList(),
                })
                .ToListAsync(CancellationToken.None) ?? throw new Exception();



            //var product = await _context.Products
            //    .Include(c=>c.Card)
            //    .Select(e=> new ProductDtoResponse
            //    {
            //        Id = e.Id,
            //        Name = e.Card!.Name,
            //        CreatedOn = e.CreatedOn.ToString("G"),
            //        Quantity = e.Card.Products!.Sum(t=>t.Quantity)
            //    })
            //    .ToListAsync(CancellationToken.None);

            //var q = product.GetAvailableStock();

            //return product.Adapt<List<ProductDtoResponse>>();
            return product;

            //return await _context.Products.
            //    ProjectToType<ProductDtoResponse>()
            //    .AsNoTracking()
            //    .ToListAsync(CancellationToken.None);
        }

        /// <summary>
        /// Добавить товар в карточку 
        /// </summary>
        /// <param name="productDto"></param>
        /// <returns></returns>
        public async Task AddProductToCardAsync(CreateProductDto productDto)
        {
            var product = productDto.Adapt<Product>();
            _context.Products.Add(product);
            await _context.SaveChangesAsync(CancellationToken.None);

        }


        public async Task<List<Product>> AddProductAsync(List<CreateProductDto> productDto)
        {


            var prod = await _context.Products.ToListAsync(CancellationToken.None);

            var products = productDto.Adapt<List<Product>>();


            await _context.Products.BulkInsertAsync(products);


            return products;
        }


        //public async Task<Product> UpdateQuantityAsync(ProductQuantityRequest quantity)
        //{
        //    //await _context.Products
        //    //    .Where(p => p.Id == quantity.ProductId)
        //    //    .ExecuteUpdateAsync(s => s.SetProperty(q => q.Quantity, q => q.Quantity - quantity.Quantity));



        //    //var list = new List<int>
        //    //{
        //    //    12
        //    //};
        //    //var p = await _context.Products.BulkReadAsync(list, e => e.Quantity);


        //    //var box = await _context.Boxes
        //    //    .Include(p=>p.Products)
        //    //    .FirstOrDefaultAsync(CancellationToken.None);
        //    //var products = box.Products;


        //    var product = await _context.Products
        //        .Select(p => new Product()
        //        {
        //            Id = p.Id,
        //            Name = p.Name,
        //            Barcode = p.Barcode,
        //            Quantity = p.ProductBoxes.Sum(pb => pb.Quantity),
        //            //CreatedOn = p.CreatedOn.ToString("G")
        //            //ProductBoxes = p.ProductBoxes
        //        })
        //        .ToListAsync(CancellationToken.None);


        //    return product.FirstOrDefault();

        //}



        //// получить список товара на складе 
        //public async Task<List<ProductDtoResponse>> GetStockProductListAsync()
        //{
        //    var productsList = await _context.Products
        //        //.Where(p => p.Id == 1)
        //        .Select(p => new ProductDtoResponse()
        //        {
        //            Id = p.Id,
        //            Name = p.Name,
        //            Barcode = p.Barcode,
        //            Quantity = p.ProductBoxes.Sum(pb => pb.Quantity),
        //            CreatedOn = p.CreatedOn.ToString("G"),
        //            ProductBox = p.Boxes,
        //            Count = p.ProductBoxes.Select(e=>e.Quantity).ToArray()
        //        })
        //        .ToListAsync(CancellationToken.None);
        //    return productsList;
        //}











        public async Task<ProductDtoResponse> GetProductByBarcode(string barcode)
        {
            var product = await _context.Cards
                              .Select(e => new ProductDtoResponse
                              {
                                  Name = e.Name,
                                  Description = e.Description,
                                  Barcode = e.Barcode
                              })
                .FirstOrDefaultAsync(x => x.Barcode == barcode, CancellationToken.None)
                          ?? throw new Exception("не найден");
            return product;
        }

        public async Task<ProductDtoResponse> GetProductAsync(int id)
        {
            var product = await _context.Cards
                              .ProjectToType<ProductDtoResponse>()
                              .AsNoTracking()
                              .FirstOrDefaultAsync(x => x.Id == id, CancellationToken.None)
                          ?? throw new Exception("Товар не найден");
            return product;
        }


        public async Task UpdateAsync(List<ProductDtoRequest> dtoList)
        {
            var products = dtoList.Adapt<List<Card>>();

            await _context.Cards.BulkUpdateAsync(products);

        }

        public async Task DeleteAsync(int id)
        {
            await _context.Cards.Where(k => k.Id == id)
                .ExecuteDeleteAsync(CancellationToken.None);
        }

        public async Task AddCardAsync(CardRequest cardRequest)
        {
            var card = cardRequest.Adapt<Card>();
            _context.Cards.Add(card);
            await _context.SaveChangesAsync(CancellationToken.None);
        }

        public Task<List<Product>> AddProductsAsync(List<CreateProductDto> productDto)
        {
            throw new NotImplementedException();
        }
    }
}
