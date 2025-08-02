using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace VehicleRentalSystem.Models
{
    public class Customer
    {
        public int Customer_Id { get; set; }
        public string Customer_Name { get; set; } = string.Empty;

        public override string ToString() => $"Customer Id: {Customer_Id}, Name: {Customer_Name}";


    }
}
