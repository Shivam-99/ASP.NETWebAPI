using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerApi.Models;

namespace CustomerApi
{
    public interface ICustomer
    {
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer customer);
        void DeleteCustomer(int id);
        void UpdateCustomer(Customer customer);
    }
}
