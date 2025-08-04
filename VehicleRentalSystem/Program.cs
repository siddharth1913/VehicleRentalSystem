using VehicleRentalSystem.Services;

class Program
{
    static void main()
    {
        CustomerServices customerServices = new CustomerServices();
        VehicleServices vehicleServices = new VehicleServices();
        RentalServices rentalServices = new RentalServices(customerServices, vehicleServices);

        while (true)
        {
            Console.WriteLine("\n==== Vehcile Rental System =====");
            Console.WriteLine("1.Register Customer");
            Console.WriteLine("2.Show All Customers");
            Console.WriteLine("3.Add Vehicle");
            Console.WriteLine("4.Show All Vehicles");
            Console.WriteLine("5.Book Vehicles");
            Console.WriteLine("6.Exit");
            Console.Write("Select option : ");

            string? choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    customerServices.RegisterCustomer();
                    break;
                case "2":
                    customerServices.ShowCustomers();
                    break;
                case "3":
                    vehicleServices.AddVehicle();
                    break;
                case "4":
                    vehicleServices.ShowVehicles();
                    break;
                case "5":
                    rentalServices.BookVehicle();
                    break;
                case "6":
                    Console.WriteLine("Exiting...");
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;

            }
        }

    }
}