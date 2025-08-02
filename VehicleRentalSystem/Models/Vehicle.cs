using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleRentalSystem.Models
{
    public abstract class Vehicle
    {
        public int Vehicle_Id { get; set; }
        public string Model { get; set; }
        public bool IsBooked { get; set; }
        public int? BookedByCustomerID { get; set; }

        public abstract decimal CalculateRent(int days);
    }
}
