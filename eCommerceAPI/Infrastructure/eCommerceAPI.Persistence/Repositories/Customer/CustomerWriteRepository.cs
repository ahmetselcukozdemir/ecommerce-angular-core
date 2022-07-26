using eCommerceAPI.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceAPI.Persistence.Repositories.Customer
{
    public class CustomerWriteRepository : WriteRepository<eCommerceAPI.Domain.Entities.Customer>, Application.Repositories.Customer.ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceDBContext context) : base(context)
        {
        }
    }
}
