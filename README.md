#  Eco-Ride Urban Mobility System

Welcome to the **Eco-Ride Urban Mobility System** - A C# demonstration of Object-Oriented Programming principles with abstract classes, inheritance, and polymorphism.

---

## 🛠 Tech Stack
- **Language:** C#
- **Framework:** .NET
- **Tools:** Visual Studio
- **Version Control:** Git & GitHub

---

##  Problem Overview

Eco-Ride is an urban mobility management system designed to handle multiple types of electric vehicles including cars and scooters. The project demonstrates core OOP concepts through a vehicle rental system that calculates trip costs for different vehicle types based on distance traveled.

### Key Features
-  **Electric Car** - Seating capacity management with distance-based trip cost calculation
-  **Electric Scooter** - Speed limit tracking with trip cost calculation
-  **Battery Management** - Percentage-based battery status tracking
-  **Maintenance Tracking** - Vehicle maintenance status monitoring

---

##  Project Architecture

### Class Hierarchy

```
Vehicle (Abstract Base Class)
├── ElectricCar
│   └── Seating Capacity: 5 passengers
│   └── Cost: Base Rate $5 + $0.5 per km
└── ElectricScooter
    └── Max Speed Limit: 25 km/h
    └── Cost: Base Rate $1 + $0.15 per km
```

---

##  Project Structure

```
Eco-Ride/
├── Vehicle.cs              # Abstract base class for all vehicles
├── ElectricCar.cs          # Electric car implementation
├── ElectricScooter.cs      # Electric scooter implementation
├── EcoRideMain.cs          # Application entry point and demo
├── Eco-Ride.csproj         # Project configuration file
├── README.md              # This file
└── .gitignore             # Git ignore configuration
```

---

### Core Classes

#### **Vehicle.cs** (Abstract Base Class)
- **Abstract Method**: `calculate_trip_cost(int distance)` - To be implemented by subclasses
- **Properties**: 
  - Vehicle ID and Model
  - Battery Percentage (0-100 validation)
  - Maintenance Status
  - Battery Percentage
- **Methods**: Getter and setter methods for all private members

#### **ElectricCar.cs** (Inherits from Vehicle)
- **Constructor**: Takes vehicle ID, model name, and seating capacity
- **Seating Capacity**: Stores passenger capacity (default: 5)
- **Trip Cost Calculation**: `5 + (0.5 × distance)`
  
#### **ElectricScooter.cs** (Inherits from Vehicle)
- **Constructor**: Takes vehicle ID, model name, and max speed limit
- **Speed Limit**: Maximum operating speed (default: 25 km/h)
- **Trip Cost Calculation**: `1 + (0.15 × distance)`

#### **EcoRideMain.cs** (Entry Point)
- Demonstrates vehicle instantiation
- Shows trip cost calculation for both vehicle types

---

### Sample Output

```
Welcome to Eco-Ride Urban Mobility System
-----------------------------------------
Vehicle ID: 1, Model: EcoCar Model X, Maintainance Status: Good, Distance covered: 10km
The total trip cost for the electric car is: $10
------------------------------
Vehicle ID: 2, Model: EcoScooter Model S, Maintainance Status: Needs Service, Distance covered: 10km
The total trip cost for the electric scooter is: $2.5
------------------------------
```

---

##  Learning Objectives

- **Abstract Classes**: Using `Vehicle` as an abstract base class
- **Inheritance**: `ElectricCar` and `ElectricScooter` inherit from `Vehicle`
- **Encapsulation**: Private fields with public getter/setter methods
- **Polymorphism**: Different implementations of `calculate_trip_cost()` method
- **Object-Oriented Design**: Single Responsibility Principle for each class
- **Input Validation**: Battery percentage validation (0-100 range)

---

## 👤 Author
**Prashant Varshney**  
B.Tech CSE (Data Analytics)  
