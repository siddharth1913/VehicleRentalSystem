using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalSystem.Models;

namespace VehicleRentalSystem.Services
{
    public class CustomerServices
    {
        private readonly List<Customer> _customers = new();
        // To identity customer uniquely
        private int _nextId = 1;

        public void RegisterCustomer()
        {
            Console.Write("Enter customers name : ");
            string? customer_Name = Console.ReadLine();

            if (!string.IsNullOrEmpty(customer_Name))
            {
                Console.WriteLine("Invalid name.");
                return;
            }

            var customer = new Customer { Customer_Id = _nextId++, Customer_Name = customer_Name };
            _customers.Add(customer);

        }

        public void ShowCustomer()
        {
            if(_customers.Count == 0)
            {
                Console.WriteLine("No customers available.");
                return;
            }

            foreach(var customer in _customers)
            {
                Console.WriteLine(customer);
            }
        }

        public Customer? CustomerById(int id)
        {
            return _customers.FirstOrDefault(c => c.Customer_Id == id);
        }

    }
}
