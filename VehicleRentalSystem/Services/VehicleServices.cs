using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using VehicleRentalSystem.Models;

namespace VehicleRentalSystem.Services
{
    public class VehicleServices
    {
        private readonly List<Vehicle> _vehicle = new();
        private int _nextVehicleId = 1;

        public void AddVehicle()
        {
            Console.Write("Enter type (car/bike) : ");
            string? type = Console.ReadLine()?.ToLower();

            Console.Write("Vehicle Modal Name : ");
            string? model = Console.ReadLine();


            Vehicle? vehicle = type switch
            {
                // model! = The ! is the null-forgiving operator, which tells the compiler to assume that model will not be null at this point.
                "car" => new Car { Vehicle_Id = _nextVehicleId++, Model = model!, IsBooked = false },
                "bike" => new Bike { Vehicle_Id = _nextVehicleId++, Model = model!, IsBooked = false },
                _ => null
            };

            if(vehicle != null)
            {
                _vehicle.Add(vehicle);
                Console.WriteLine("Vehcile added successfully.");
            }
            else
            {
                Console.WriteLine("Invalid vehicle type.");
            }
        }

        public void ShowVehicles()
        {
            if(_vehicle.Count == 0)
            {
                Console.WriteLine("No vehicles available.");
                return;
            }

            foreach(var vehicle in _vehicle)
            {
                Console.WriteLine(vehicle);
            }
        }

        public Vehicle? GetVehicleById(int id)
        {
            return _vehicle.FirstOrDefault(c => c.Vehicle_Id == id);
        }
    }
}
