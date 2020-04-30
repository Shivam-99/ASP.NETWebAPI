using CustomerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerApi
{
    public class CustomerDbHandler : ICustomer
    {
        private CustomerContext context;

        public CustomerDbHandler(CustomerContext _context)
        {
            context = _context;
        }
        public void AddCustomer(Customer customer)
        {

            context.Customers.Add(customer);
            context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            Customer ToBeDeleted = context.Customers.Find(id);
            context.Customers.Remove(ToBeDeleted);
            context.SaveChanges();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return context.Customers;
        }

        public void UpdateCustomer(Customer customer)
        {
            context.Customers.Update(customer);
            context.SaveChanges();
        }
    }
}
