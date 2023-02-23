List<Box> boxes = new List<Box>();

while (true)
{
    string[] currentProduct = Console.ReadLine().Split();

    if (currentProduct[0] == "end")
    {
        break;
    }
    string serialNumber = currentProduct[0];
    string productName = currentProduct[1];
    int quantity = int.Parse(currentProduct[2]);
    double productPrice = double.Parse(currentProduct[3]);

    Item item = new Item()
    {
        Name = productName,
        Price = productPrice
    };

    Box box = new Box()
    {
        SerialNumber = serialNumber,
        Item = item,
        ItemQuantity = quantity,
        PriceForABox = quantity * productPrice
    };

    boxes.Add(box);
}

foreach (var box in boxes.OrderByDescending(x => x.PriceForABox))
{
    Console.WriteLine(box.SerialNumber);
    Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
    Console.WriteLine($"-- ${box.PriceForABox:f2}");
}


class Item
{

    public string Name { get; set; }
    public double Price { get; set; }
}

class Box
{
    public string SerialNumber {get; set;}
    public Item Item { get; set;}
    public int ItemQuantity { get; set;}
    public double PriceForABox { get; set;}
}