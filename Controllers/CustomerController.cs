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
        private CustomerContext context;
        public CustomerController(CustomerContext _context)
        {
            context = _context;
        }
        // GET: api/Customer
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return context.Customers;
            //return new string[] { "value1", "value2" };
        }

        // GET: api/Customer/5
        /*[HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }*/

        // POST: api/Customer
        [HttpPost]
        public void Post(Customer customer)
        {
            context.Customers.Add(customer);
            context.SaveChanges();
        }

        // PUT: api/Customer/5
        [HttpPut]
        public void Put(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Customer ToBeDeleted = context.Customers.Find(id);
            context.Customers.Remove(ToBeDeleted);
            context.SaveChanges();

        }
    }
}
