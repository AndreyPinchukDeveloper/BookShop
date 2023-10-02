using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Shop.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Persistence
{
    /// <summary>
    /// Add db context to use and register it
    /// </summary>
    public static class DependencyImjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<BooksDbContext>(options =>
            {
                options.UseSqlite(connectionString);
            });
            services.AddScoped<IBooksDbContext>(provider =>
                provider.GetService<BooksDbContext>());
            return services;
        }
    }
}
