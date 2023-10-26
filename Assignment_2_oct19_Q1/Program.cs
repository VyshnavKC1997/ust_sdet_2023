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

using Assignment_2_oct19_Q1;
/*
Employee employee = new Employee(1, "vyshnav", "KC", 2);
employee.Displayinfo();*/

/*using Assignment_2_oct19_Q1;

Circle circle = new Circle(3);
circle.Draw();
Rectangle rectangle = new Rectangle(5, 3);
rectangle.Draw();*/

/*InsurancePolicy insurancePolicy = new(12, "life policy", 150000);
Console.WriteLine("enter the new policy amount");
double policyamount=Convert.ToDouble(Console.ReadLine());   
insurancePolicy.RenewPolicy(policyamount);
Console.WriteLine("new Policy amount");
insurancePolicy.Display();
insurancePolicy.RenewPolicy();
Console.WriteLine("auto increment new Policy amount " );
insurancePolicy.Display();  */

/*CarInsurance carInsurance = new CarInsurance();
carInsurance.VehicleType = "private";
carInsurance.PolicyId = 1;
carInsurance.PolicyName = "Car insurance";
carInsurance.PremiumAmount = 1000000;
Console.WriteLine("policy id:{0}\tPolicy Name:{1}\tPremium Amount:{2}\tVehicle type:{3}",carInsurance.PolicyId
    ,carInsurance.PolicyName,carInsurance.CalculatePremium(),carInsurance.VehicleType);

LifeInsurance lifeInsurance = new LifeInsurance();
lifeInsurance.PolicyId = 2;
lifeInsurance.PolicyName = "Life insurance";
lifeInsurance.PremiumAmount = 2000000;
lifeInsurance.Age = 75;
Console.WriteLine("policy id:{0}\tPolicy Name:{1}\tPremium Amount:{2}\tAge:{3}", lifeInsurance.PolicyId,
    lifeInsurance.PolicyName, lifeInsurance.CalculatePremium(), lifeInsurance.Age);*/

/*Customer customer = new Customer();
customer.CustomerId = 1;
customer.CustomerName = "vyshnav";
customer.Balance = 3321.1;
customer.PhoneNumber = 263551265;

Customer customer1 = new Customer();
customer1.CustomerId = 2;
customer1.CustomerName = "vishnu";
customer1.Balance = 332.1;
customer1.PhoneNumber = 25643551265;

Customer customer2 = new Customer();
customer2.CustomerId = 3;
customer2.CustomerName = "vikas";
customer2.Balance = 33231.1;
customer2.PhoneNumber = 656551265;

Customer.list.Add(customer);
Customer.list.Add(customer1);
Customer.list.Add(customer2);*/

/*
customer.SearchCustomer(342124421);
customer.DisplayDetails();
*/


/*CallRecord callRecord = new CallRecord();
callRecord.CallId = 1;
callRecord.CallTime = 32;
callRecord.PhoneNumber = 1234567890;

CallRecord callRecord1 = new CallRecord();
callRecord1.CallId = 2;
callRecord1.CallTime = 44;
callRecord1.PhoneNumber = 4355255434;

CallRecord callRecord2 = new CallRecord();
callRecord2.CallId = 3;
callRecord2.CallTime = 24;
callRecord2.PhoneNumber = 1234567890;


CallRecord.callRecords.Add(callRecord);
CallRecord.callRecords.Add(callRecord1);
CallRecord.callRecords.Add(callRecord2);

callRecord.CallHistory(1234567890);
callRecord.TotalCall();
*/
using Assignment_2_oct19_Q1.ExceptionHandling;

for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter the Patient Id");
    int patientId = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine("Enter patient Name");
    string? name = Console.ReadLine();
    Console.WriteLine("enter the age");
    int age = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter Diagnosis");
    string? diagnosis = Console.ReadLine();

    Patient patient = new Patient();
    try
    {
        patient.GetPatient(patientId, age,name, diagnosis);
    }
    catch (PatientException exe)
    {
        Console.WriteLine(exe.Message);
    }
}