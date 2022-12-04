using Microsoft.AspNetCore.Mvc;
using sentinelapi.Entities;
using sentinelapi.Services.Interface;

namespace sentinel.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerInterface _iCustomerInterface;

        public CustomerController(ICustomerInterface icustomerInterface)

        {

            _iCustomerInterface = icustomerInterface;
        }

        [HttpGet(Name = "GetAllCustomers")]
        public IEnumerable<Customer> GetAllCustomers()
        {
            return _iCustomerInterface.GetAll();

        }

        [HttpPost(Name = "AddCustomer")]
        public void Add(Customer customer)
        {
            _iCustomerInterface.AddCustomer(customer);

        }

        [HttpPut(Name = "UpdateCustomer")]
        public void Update(Customer customer)
        {
            _iCustomerInterface.UpdateCustomer(customer);

        }
    }
}
