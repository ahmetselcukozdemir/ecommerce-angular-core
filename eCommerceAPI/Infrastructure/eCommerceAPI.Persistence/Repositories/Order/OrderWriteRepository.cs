using eCommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Persistence.Repositories.Order
{
    public class OrderWriteRepository : WriteRepository<eCommerceAPI.Domain.Entities.Order>, Application.Repositories.Order.IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
