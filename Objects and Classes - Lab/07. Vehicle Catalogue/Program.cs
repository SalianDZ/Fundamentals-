Catalog catalog = new Catalog();

List<Car> cars = new List<Car>();
List<Truck> trucks = new List<Truck>();

while (true)
{
    string[] arrayInfo = Console.ReadLine().Split("/");

    if (arrayInfo[0] == "end")
    {
        break;
    }

    string vehicleType = arrayInfo[0];

    if (vehicleType == "Car")
    {
        string vehicleBrand = arrayInfo[1];
        string vehicleModel = arrayInfo[2];
        int vehicleHorsePowers = int.Parse(arrayInfo[3]);
        Car car = new Car()
        {
            Brand = vehicleBrand,
            Model = vehicleModel,
            HorsePowers = vehicleHorsePowers
        };
        catalog.Cars.Add(car);
    }
    else
    {
        string vehicleBrand = arrayInfo[1];
        string vehicleModel = arrayInfo[2];
        int vehicleWeight = int.Parse(arrayInfo[3]);

        Truck truck = new Truck()
        {
            Brand = vehicleBrand,
            Model = vehicleModel,
            Weight = vehicleWeight
        };
        catalog.Trucks.Add(truck);
    }
}

Console.WriteLine("Cars:");
foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePowers}hp");
}
Console.WriteLine("Trucks:");
foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
{
    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
}

class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

}

class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePowers { get; set; }

}

class Catalog
{
    public Catalog()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }
}