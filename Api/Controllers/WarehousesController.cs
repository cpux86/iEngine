using Application.DTO.Product;
using Application.DTO.Warehouse;
using Application.Interfaces;
using Domain.Entities.ProductAggregate;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc.Routing;
using System.Text;

namespace Api.Controllers
{
    /// <summary>
    /// Управление складом
    /// </summary>
    [ApiController]
    //[Route("[controller]")]
    //[Route("wh")]
    public class WarehousesController :  ControllerBase
    {
        private readonly IWarehouseManager _warehouseManager;

        public WarehousesController(IWarehouseManager warehouseManager)
        {
            _warehouseManager = warehouseManager;
        }

        /// <summary>
        /// Добавить новый склад
        /// </summary>
        /// <param name="wh"></param>
        [HttpPost]
        [Route("add")]
        public async Task Add([FromBody] CreateWarehouseDto wh)
        {
            //var t = RandomNumberGenerator.GetInt32(int.MaxValue);

            ////Создание объекта для генерации чисел
            //Random rnd = new Random();

            ////Получить случайное число (в диапазоне от 0 до 10)
            ////var list = new List<long>();
            //var list = new HashSet<Guid>();
            

            //for (int i = 0; i < 10000000; i++)
            //{
            //    //var value = rnd.NextInt64(4600000000000, 4609999999999);
            //    //var value = RandomNumberGenerator.GetInt32(460000000, 469999999);
                
            //    //if (list.Any(e => e == value)) throw new Exception("Конфликт");
            //    list.Add(Guid.NewGuid());
            //}

            //var l = list.OrderBy(e => e);
            
            
            await _warehouseManager.CreateAsync(wh.Name);
        }
    }
}
