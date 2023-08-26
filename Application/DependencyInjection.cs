using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Product;
using Application.Services;
using Domain.Entities.ProductAggregate;
using Mapster;
using System.Reflection;
using MapsterMapper;

namespace Application
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IDocumentServices, DocumentServices>();
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<IWarehouseManager,  WarehouseManager>();

            var config = new TypeAdapterConfig();
            services.AddSingleton(config);

            services.AddScoped<IMapper, ServiceMapper>();


            TypeAdapterConfig<ProductDtoResponse, Card>
                .NewConfig()
                .Map(dest => dest.Name, src => src.Name.Trim())
                .Map(dest => dest.Description, src => src.Description.Trim());
        }
    }
}
