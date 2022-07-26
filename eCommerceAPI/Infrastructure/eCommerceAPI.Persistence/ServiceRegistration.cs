using Microsoft.EntityFrameworkCore;
using eCommerceAPI.Application.Abstractions;
using eCommerceAPI.Persistence.Concretes;
using eCommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace eCommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductService>();


            services.AddDbContext<ECommerceDBContext>(options => options.UseNpgsql(""));
        }
    }
}
