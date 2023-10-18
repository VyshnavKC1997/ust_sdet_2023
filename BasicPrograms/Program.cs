// See https://aka.ms/new-console-template for more information
/*using BasicPrograms;

int numberOne, numberTwo;
Console.WriteLine("Enter two numbers");
numberOne = Convert.ToInt32(Console.ReadLine());
numberTwo = Convert.ToInt32(Console.ReadLine());
Calculation calculation = new Calculation();
Console.WriteLine(calculation.Add(numberOne, numberTwo));*/


using BasicPrograms;

Electricity electricity = new (12345,9000,9300,"XX");
double bill = electricity.CalculateBill();
Console.WriteLine(bill);