// See https://aka.ms/new-console-template for more information
/*using Assignment_2_oct19_Q1;

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
}*/


/*using Assignment_2_oct19_Q1;

ElectronicProduct electronicProduct = new ElectronicProduct("Table", 23000, 30, 5);
electronicProduct.DisplayProduct();
electronicProduct.ProductValue();
electronicProduct.ElectronicWarrenty();



DigitalProduct digitalProduct=new DigitalProduct("Song", 24, 30, 5,"MP3");
digitalProduct.DisplayProduct();
digitalProduct.ProductValue();
digitalProduct.ElectronicWarrenty();
digitalProduct.DigitalProductFileFormatDisplay();

ClothingProduct clothingProduct = new ClothingProduct("Shirt", 2000, 30, "Medium");
clothingProduct.DisplayProduct();
clothingProduct.ProductValue();
clothingProduct.DisplayClothSize(); */
/*
using Assignment_2_oct19_Q1;

Employee employee = new Employee(1, "vyshnav", "KC", 24);
employee.DisplayInfo();*/

using Assignment_2_oct19_Q1;

Circle circle = new Circle(3);
circle.Draw();
Rectangle rectangle = new Rectangle(5, 3);
rectangle.Draw();


