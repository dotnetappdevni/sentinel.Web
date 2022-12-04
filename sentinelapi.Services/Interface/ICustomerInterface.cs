using sentinelapi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Services.Interface
{
    public  interface ICustomerInterface
    {
         IEnumerable<Customer> GetAll();

        void AddCustomer(Customer customer);

        void UpdateCustomer(Customer customer);

    }
}
