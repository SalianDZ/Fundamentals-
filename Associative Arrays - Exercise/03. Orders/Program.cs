using System.Linq;
using System.Security.Cryptography.X509Certificates;

List<Product> products = new List<Product>();
while (true)
{
    string[] currentProduct = Console.ReadLine()
        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
        .ToArray();

    if (currentProduct[0] == "buy")
    {
        break;
    }

    string productName = currentProduct[0];
    double productPrice = double.Parse(currentProduct[1]);
    int productQuantity = int.Parse(currentProduct[2]);

    Product product = new Product(productName, productPrice, productQuantity);

    if (products.Any(x => x.ProductName == productName))
    {
        foreach (var currentProductInList in products)
        {
            if (currentProductInList.ProductName == productName)
            {
                currentProductInList.ProductPrice = productPrice;
                currentProductInList.ProductQuantity += productQuantity;
            }

        }
    }
    else
    {
        products.Add(product);
    }
}

foreach (var currentProduct in products)
{
    Console.WriteLine($"{currentProduct.ProductName} -> {currentProduct.ProductQuantity * currentProduct.ProductPrice:f2}");
}



public class Product
{
    public Product(string productName, double productPrice, int productQuantity)
    {
        ProductName = productName;
        ProductPrice = productPrice;
        ProductQuantity = productQuantity;
    }

    public string ProductName { get; set; }

    public double ProductPrice { get; set; }

    public int ProductQuantity { get; set; }
}