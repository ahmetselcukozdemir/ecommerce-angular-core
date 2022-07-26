using eCommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Persistence.Repositories.Product
{
    internal class ProductReadRepository : ReadRepository<eCommerceAPI.Domain.Entities.Product>, Application.Repositories.Product.IProductReadRepository
    {
        public ProductReadRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
