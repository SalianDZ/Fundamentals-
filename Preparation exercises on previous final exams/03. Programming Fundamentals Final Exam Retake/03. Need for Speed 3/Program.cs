Dictionary<string, Car> cars = new Dictionary<string, Car>();
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] carInfo = Console.ReadLine()
        .Split("|", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    string carName = carInfo[0];
    int carMileage = int.Parse(carInfo[1]);
    int carFuel = int.Parse(carInfo[2]);

    if (!cars.ContainsKey(carName))
    {
        cars[carName] = new Car(carMileage, carFuel);
        continue;
    }

    cars[carName].Fuel = carFuel;
    cars[carName].Mileage = carMileage;
}

while (true)
{
    string[] carInfo = Console.ReadLine()
        .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (carInfo[0] == "Stop")
    {
        break;
    }
    else if (carInfo[0] == "Drive")
    {
        string carName = carInfo[1];
        int distance = int.Parse(carInfo[2]);
        int fuel = int.Parse(carInfo[3]);

        if (cars[carName].Fuel - fuel >= 0)
        {
            cars[carName].Fuel -= fuel;
            cars[carName].Mileage += distance;
            Console.WriteLine($"{carName} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
        }
        else
        {
            Console.WriteLine("Not enough fuel to make that ride");
        }

        if (cars[carName].Mileage >= 100000)
        {
            cars.Remove(carName);
            Console.WriteLine($"Time to sell the {carName}!");
        }
    }
    else if (carInfo[0] == "Refuel")
    {
        string carName = carInfo[1];
        int fuel = int.Parse(carInfo[2]);

        if (cars[carName].Fuel + fuel > 75)
        {
            Console.WriteLine($"{carName} refueled with {75 - cars[carName].Fuel} liters");
            cars[carName].Fuel = 75;
            continue;
        }

        Console.WriteLine($"{carName} refueled with {fuel} liters");
        cars[carName].Fuel += fuel;
    }
    else if (carInfo[0] == "Revert")
    {
        string carName = carInfo[1];
        int kilometers = int.Parse(carInfo[2]);

        if (cars[carName].Mileage - kilometers < 10000)
        {
            cars[carName].Mileage = 10000;
            continue;
        }

        cars[carName].Mileage -= kilometers;
        Console.WriteLine($"{carName} mileage decreased by {kilometers} kilometers");
    }
}

foreach (var car in cars)
{
    Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
}

public class Car
{
    public Car(int mileage, int fuel)
    {
        Mileage = mileage;
        Fuel = fuel;
    }

    public int Mileage { get; set; }

    public int Fuel { get; set; }
}