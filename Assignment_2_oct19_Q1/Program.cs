// See https://aka.ms/new-console-template for more information
using Assignment_2_oct19_Q1;

Product[] products = new Product[3];
for (int i = 0; i < products.Length; i++)
{
    Console.WriteLine("enter the product name");
    string? productName = Console.ReadLine();
    Console.WriteLine("enter the product price");
    double price = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("enter the product quantity");
    int quantity = Convert.ToInt32(Console.ReadLine());
    products[i] = new(productName, price, quantity);
    Console.WriteLine("next product details");
}
for (int i = 0;i < products.Length; i++)
{
    products[i].DisplayProduct();
    products[i].ProductValue();
}


