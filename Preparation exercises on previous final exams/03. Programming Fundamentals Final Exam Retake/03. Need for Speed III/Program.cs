using System.ComponentModel;

int n = int.Parse(Console.ReadLine());
Dictionary<string, CarInfo> cars = new Dictionary<string, CarInfo>();  
for (int i = 0; i < n; i++)
{
    string[] currentCar = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries);

    string currentName = currentCar[0];
    int currentMileage = int.Parse(currentCar[1]);
    int currentFuel = int.Parse(currentCar[2]);
    cars[currentName] = new CarInfo(currentMileage, currentFuel);
}

while (true)
{
    string[] command = Console.ReadLine()
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "Stop")
    {
        break;
    }
    else if (command[0] == "Drive")
    {
        string name = command[1];
        int distance = int.Parse(command[2]);
        int fuel = int.Parse(command[3]);

        if (cars.ContainsKey(name))
        {
            if (cars[name].Fuel < fuel)
            {
                Console.WriteLine("Not enough fuel to make that ride");
                continue;
            }
            cars[name].Fuel -= fuel;
            cars[name].Mileage += distance;
            Console.WriteLine($"{name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");

            if (cars[name].Mileage >= 100000)
            {
                Console.WriteLine($"Time to sell the {name}!");
                cars.Remove(name);
            }
        }
    }
    else if (command[0] == "Refuel")
    {
        string name = command[1];
        int fuel = int.Parse(command[2]);

        if (cars[name].Fuel + fuel > 75)
        {
            Console.WriteLine($"{name} refueled with {75 - cars[name].Fuel} liters");
            cars[name].Fuel = 75;
            continue;
        }

        cars[name].Fuel += fuel;
        Console.WriteLine($"{name} refueled with {fuel} liters");
    }
    else if (command[0] == "Revert")
    {
        string name = command[1];
        int kilometers = int.Parse(command[2]);

        if (cars[name].Mileage - kilometers < 10000)
        {
            cars[name].Mileage = 10000;
            continue;
        }

        cars[name].Mileage -= kilometers;
        Console.WriteLine($"{name} mileage decreased by {kilometers} kilometers");
    }
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
}


class CarInfo
{
    public CarInfo(int mileage, int fuel)
    {
        Mileage = mileage;
        Fuel = fuel;
    }

    public int Mileage { get; set; }

    public int Fuel { get; set; }
}