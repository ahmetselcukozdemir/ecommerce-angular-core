using eCommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Persistence.Repositories.Product
{
    internal class ProductWriteRepository : WriteRepository<eCommerceAPI.Domain.Entities.Product>, Application.Repositories.Product.IProductWriteRepository
    {
        public ProductWriteRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
