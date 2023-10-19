// See https://aka.ms/new-console-template for more information
/*using BasicPrograms;

int numberOne, numberTwo;
Console.WriteLine("Enter two numbers");
numberOne = Convert.ToInt32(Console.ReadLine());
numberTwo = Convert.ToInt32(Console.ReadLine());
Calculation calculation = new Calculation();
Console.WriteLine(calculation.Add(numberOne, numberTwo));*/


/*using BasicPrograms;

Electricity electricity = new (12345,9000,9300,"XX");
double bill = electricity.CalculateBill();
Console.WriteLine(bill);*/

//Employee class


/*using BasicPrograms;

Employees employees=new (111,"Aaaaa","It",10000);
Console.WriteLine("employee id:{0}" +
    "\nemployee name:{1}\n" +
    "department:{2}\n" +
    "basic pay:{3}\n" +
    "net salary:{4}",employees.EmployeeId,employees.EmployeeName,employees.Department,employees.BasicPay,employees.CalculateSalary());
*/

//ArrayClass
using BasicPrograms;

ArrayClass arrayClass = new ArrayClass();
/*Console.WriteLine("enter the 3 number");
arrayClass.ReadArray();
Console.WriteLine("Before sorting");
arrayClass.DisplayArray();
arrayClass.SortArray();
Console.WriteLine("After sorting");
arrayClass.DisplayArray();
Console.WriteLine("two dimensional");
arrayClass.ReadTwoDimensionalArray();
arrayClass.WriteArrayTwoDimension();*/

arrayClass.JaggedArray();
