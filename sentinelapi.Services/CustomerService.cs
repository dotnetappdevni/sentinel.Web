using sentinel.Persistance;
using sentinelapi.Entities;
using sentinelapi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sentinelapi.Services
{
    public class CustomerService : ICustomerInterface
    {
        private readonly ApplicationDBContext _context;

        public CustomerService(ApplicationDBContext context)
        {

            _context = context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.AsEnumerable();
        }


        public void UpdateCustomer(Customer customer)
        {

          _context.Update(customer);

            _context.SaveChanges();

        }
        public void  AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();

        }
    }
}
