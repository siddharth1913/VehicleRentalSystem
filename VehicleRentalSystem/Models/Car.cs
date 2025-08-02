using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Car: Vehicle
    {
        public override decimal CalculateRent(int days)
        {
            return 500 * days;
        }

        public override string ToString() => $"[Car] Car_Id: {Vehicle_Id}, Model: {Model}, Booked: {IsBooked}";
    }
}
