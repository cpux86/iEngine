using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{

    /* Управляющий складом.
     *
     */
    public class WarehouseManager : IWarehouseManager
    {
        private readonly IStockDbContext _stockDbContext;

        public WarehouseManager(IStockDbContext context)
        {
            _stockDbContext = context;
        }

        // Получить содержимое ячейки


        public async Task CreateAsync(string name)
        {
            var wh = new Warehouse(name);
            await _stockDbContext.Warehouses.AddAsync(wh, CancellationToken.None);
            await _stockDbContext.SaveChangesAsync(CancellationToken.None);
            //_stockDbContext.Boxes
        }


    }

    public static class BoxBuilder
    {

    }
    //public class WarehouseBuilder
    //{
    //    private readonly IStockDbContext _stockDbContext;
    //    // Создает склады, стеллажи, короба.
    //    public WarehouseBuilder(IStockDbContext stockDbContext)
    //    {
    //        _stockDbContext = stockDbContext;
    //    }

        

    //}
}
