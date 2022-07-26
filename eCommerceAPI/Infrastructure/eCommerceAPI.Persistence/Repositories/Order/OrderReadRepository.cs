using eCommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Persistence.Repositories.Order
{
    public class OrderReadRepository : ReadRepository<eCommerceAPI.Domain.Entities.Order>, Application.Repositories.Order.IOrderReadRepository
    {
        public OrderReadRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
