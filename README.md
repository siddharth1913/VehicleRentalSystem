Vehicle Rental System
A robust console-based application for managing vehicle rentals.

About The Project
This project is a foundational C# console application that serves as a proof of concept for a complete vehicle rental system. It demonstrates a strong grasp of modern software design principles and patterns. The application allows users to register customers, add vehicles (cars and bikes), and manage the booking and return process in a straightforward, command-line interface.

Technical Highlights
The system's architecture is a key feature, designed for scalability and maintainability.

Object-Oriented Programming (OOP): The application is built around a clear object model with distinct classes for Customer, Vehicle, Car, and Bike, demonstrating inheritance and polymorphism.

SOLID Principles: Adheres to SOLID principles, with a strong emphasis on the Single Responsibility Principle and Dependency Inversion. Core functionalities like booking and returns are implemented through dedicated services and interfaces (IBookable, IReturnable).

Dependency Injection (DI): Services are injected into other classes, decoupling components and making the system highly testable and extensible.

Features
👤 Customer Management: Register and view a list of all customers.

🚗 Vehicle Management: Add new vehicles and display available or booked vehicles.

📅 Booking & Returns: Seamlessly book a vehicle for a specified number of days and manage its return.

💰 Dynamic Pricing: Calculates the total rental cost based on the vehicle type and duration.

Getting Started
To get a local copy up and running, follow these simple steps.

Prerequisites
.NET SDK (Version 6.0 or higher)

Installation
Clone the repository:

git clone [https://github.com/siddharth1913/VehicleRentalSystem.git](https://github.com/siddharth1913/VehicleRentalSystem.git)


Navigate to the project directory:

cd VehicleRentalSystem


Run the application from your terminal:

dotnet run


Usage
Once the application is running, you will be prompted to enter commands to interact with the system.

Example Flow:

Register a Customer:

Enter customers name: Rajat
Customer registered successfully.


Add a Vehicle:

Enter type (car/bike): car
Vehicle Modal Name: BMW X5
Vehicle added successfully.


Book a Vehicle:

Enter Customer ID: 1
Enter Vehicle ID: 1
Enter rental days: 5
Booked successfully for Rajat. Total Rent: ₹5,000.00


Contributing
Contributions are what make the open-source community an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.

Fork the project.

Create your feature branch (git checkout -b feature/AmazingFeature).

Commit your changes (git commit -m 'Add some AmazingFeature').

Push to the branch (git push origin feature/AmazingFeature).

Open a Pull Request.

Contact
Siddharth: GitHub Profile

Project Link: https://github.com/siddharth1913/VehicleRentalSystem
