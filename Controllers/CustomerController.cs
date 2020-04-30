using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustomerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomer context;
        public CustomerController(ICustomer _context)
        {
            context = _context;
        }

        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return context.GetAllCustomers();
        }
        
        // POST: api/Customer

        [HttpPost]
        public void Post(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.AddCustomer(customer);
            }
        }

        // PUT: api/Customer
        [HttpPut]
        public void Put(Customer customer)
        {
            if (ModelState.IsValid)
            {
                context.UpdateCustomer(customer);
            }
            
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            context.DeleteCustomer(id);
        }
    }
}
