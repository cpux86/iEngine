using Application.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static void AddPersistence(this IServiceCollection services)
        {
            services.AddScoped<IStockDbContext, StockDbContext>();
            services.AddDbContextPool<StockDbContext>(options =>
            {
                options.UseSqlite(@"DataSource=C:\CSharp\iEngine\DB\iE.db");
                options.LogTo(message => System.Diagnostics.Debug.WriteLine(message));
            });
        }
    }
}