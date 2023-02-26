using System;
using System.Collections;
using System.Text;
using System.Linq;
using System.Text;
using System.Collections.Generic;

List<Vehicle> vehicles = new List<Vehicle>();

while (true)
{
    string[] inputArgs = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (inputArgs[0] == "End")
    {
        break;
    }

    VehicleType vehicleType;
    bool isVehicleTypeParseSuccessful = Enum.TryParse(inputArgs[0], ignoreCase: true,
        out vehicleType);

    if (isVehicleTypeParseSuccessful)
    {
        string vehicleModel = inputArgs[1];
        string vehicleColor = inputArgs[2];
        int vehicleHorsePower = int.Parse(inputArgs[3]);

        var currentVehicle = new Vehicle(vehicleType, vehicleModel, vehicleColor, vehicleHorsePower);
        vehicles.Add(currentVehicle);
    }
}

while (true)
{
    string cmds = Console.ReadLine();

    if (cmds == "Close the Catalogue")
    {
        break;
    }

    var desiredVehicle = vehicles.FirstOrDefault(vehicle => vehicle.Model == cmds);
    Console.WriteLine(desiredVehicle);
}

    var cars = vehicles.Where(vehicle => vehicle.Type == VehicleType.Car).ToList();
    var trucks = vehicles.Where(vehicle => vehicle.Type == VehicleType.Truck).ToList();

    double carsAvgHorsePower = cars.Count > 0 ? cars.Average(car => car.HorsePower) : 0.00;
    double trucksAvgHorsePower = trucks.Count > 0 ? trucks.Average(truck => truck.HorsePower) : 0.00;

    Console.WriteLine($"Cars have average horsepower of: {carsAvgHorsePower:f2}.");
    Console.WriteLine($"Trucks have average horsepower of: {trucksAvgHorsePower:f2}.");





enum VehicleType 
{
    Car,
    Truck
}
class Vehicle
{
    public Vehicle(VehicleType type, string model, string color, int horsePower)
    {
        Type = type;
        Model = model;
        Color = color;
        HorsePower = horsePower;
    }

    public VehicleType Type { get; set; }

    public string Model { get; set; }

    public string Color { get; set; }

    public int HorsePower { get; set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"Type: {Type}");
        sb.AppendLine($"Model: {Model}");
        sb.AppendLine($"Color: {Color}");
        sb.AppendLine($"Horsepower: {HorsePower}");

        return sb.ToString().TrimEnd();
    }
}

