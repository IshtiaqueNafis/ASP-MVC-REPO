using System.Collections.Generic;
using Vidly.Models;

namespace Vidly.Data
{
    public class CustomerRepository
    {
        private static List<Customer> _customers = new List<Customer>
        {
            new Customer {Id = 1, Name = "nafis"},
            new Customer {Id = 2, Name = "nafu"}
        };

        public List<Customer> GetCustomers () => _customers; // this is the getter 


        public Customer GetCustomer(int id)
        {
            Customer customerToReturn = null;

            foreach (var customer in _customers)
            {
                if (customer.Id == id)
                {
                    customerToReturn = customer;
                    break;
                }
            }
            return customerToReturn;
        }


    }
}