using CleanArqui.Entities.Interfaces;
using CleanArqui.RepositoryEFCore.DataContext;
using CleanArqui.RepositoryEFCore.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArqui.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositories(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CleanArquiContext>(options => 
                options.UseSqlServer(  
                    configuration.GetConnectionString("CleanArqui")));

            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}
