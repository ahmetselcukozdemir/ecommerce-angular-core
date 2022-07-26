using Microsoft.EntityFrameworkCore;
using eCommerceAPI.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceAPI.Application.Repositories;
using eCommerceAPI.Persistence.Repositories;
using eCommerceAPI.Application.Repositories.Customer;
using eCommerceAPI.Persistence.Repositories.Customer;
using eCommerceAPI.Application.Repositories.Order;
using eCommerceAPI.Persistence.Repositories.Order;
using eCommerceAPI.Application.Repositories.Product;
using eCommerceAPI.Persistence.Repositories.Product;

namespace eCommerceAPI.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistanceServices(this IServiceCollection services)
        {
            //services.AddSingleton<IProductService, ProductService>();


            services.AddDbContext<ECommerceDBContext>(options => options.UseNpgsql(Configuration.ConnectionString));

            services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            services.AddScoped<IOrderReadRepository, OrderReadRepository>();
            services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();

        }
    }
}
