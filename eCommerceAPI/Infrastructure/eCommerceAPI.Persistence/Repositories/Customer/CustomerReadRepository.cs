using eCommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Persistence.Repositories.Customer
{
    public class CustomerReadRepository : ReadRepository<eCommerceAPI.Domain.Entities.Customer>, Application.Repositories.Customer.ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
