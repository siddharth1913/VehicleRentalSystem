using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public class Bike: Vehicle
    {
        public override decimal CalculateRent(int days)
        {
            return 200 * days;
        }

        public override string ToString() => $"[Bike] Bike_Id: {Vehicle_Id}, Model: {Model}, Booked: {IsBooked}";
    }
}
