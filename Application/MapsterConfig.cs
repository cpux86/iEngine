using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.DTO.Product;
using Domain.Entities;
using Domain.Entities.ProductAggregate;
using Mapster;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class MapsterConfig
    {
        //public static void RegisterMapsterConfiguration(this ServiceCollection services)
        //{
        //    TypeAdapterConfig<ProductDto,Product >
        //        .NewConfig()
        //        .Map(dest => dest.Name, src => src.Name);
        //}
    }
}
