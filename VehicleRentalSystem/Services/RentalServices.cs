using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalSystem.Interfaces;

namespace VehicleRentalSystem.Services
{
    public class RentalServices : IBookable, IReturnable
    {
        private readonly CustomerServices _customerServices;
        private readonly VehicleServices _vehicleServices;
        public RentalServices(CustomerServices customerServices, VehicleServices vehicleServices)
        {
            _customerServices = customerServices;
            _vehicleServices = vehicleServices;
        }

        public void BookVehicle()
        {
            Console.Write("Enter Customer ID : ");
            if (!int.TryParse(Console.ReadLine(), out int customerId)) {
                Console.WriteLine("Invalid input");
                return;
            }

            var customer = _customerServices.GetCustomerById(customerId);
            if (customer == null)
            {
                Console.WriteLine("Customer not found");
                return;
            }

            Console.Write("Enter Vehicle ID : ");
            if (!int.TryParse(Console.ReadLine(), out int vehicleId))
            {
                Console.WriteLine("Invalid input");
                return;
            }

            var vehicle = _vehicleServices.GetVehicleById(vehicleId);
            if (vehicle == null || vehicle.IsBooked)
            {
                Console.WriteLine("Vehicle not available");
            }

            Console.Write("Enter rental days : ");
            if (!int.TryParse(Console.ReadLine(), out int days)  || days <= 0){
                Console.WriteLine("Invalid number of days");
                return;
            }

            var cost = vehicle.CalculateRent(days);
            vehicle.IsBooked = true;
            vehicle.BookedByCustomerID = null;

            Console.WriteLine($"Vehicle {vehicle.Model} (ID: {vehicle.Vehicle_Id}) returned successfully.");

        }

        public void ReturnVehicle()
        {
            Console.Write("Enter Vehicle ID to return : ");
            if(!int.TryParse(Console.ReadLine(), out int vehicleId))
            {
                Console.WriteLine("Invalid ID");
                return;
            }

            var vehicle = _vehicleServices.GetVehicleById(vehicleId);

            if(vehicle == null || vehicle.IsBooked)
            {
                Console.WriteLine("Vehicle not found or not booked.");
                return;
            }


            vehicle.IsBooked = false;
            vehicle.BookedByCustomerID = null;
            Console.WriteLine($"Vehicle {vehicle.Model} (ID: {vehicle.Vehicle_Id}) returned successfully.");
            
        }
    }
}
