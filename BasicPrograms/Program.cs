﻿// See https://aka.ms/new-console-template for more information
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
/*using BasicPrograms;

ArrayClass arrayClass = new ArrayClass();
Console.WriteLine("enter the 3 number");
arrayClass.ReadArray();
Console.WriteLine("Before sorting");
arrayClass.DisplayArray();
arrayClass.SortArray();
Console.WriteLine("After sorting");
arrayClass.DisplayArray();
Console.WriteLine("two dimensional");
arrayClass.ReadTwoDimensionalArray();
arrayClass.WriteArrayTwoDimension();

arrayClass.JaggedArray();*/

/*
using BasicPrograms;
using BasicPrograms.ExeptionMessage;
using System.Transactions;*/

/*StudentMarks studentMarks = new StudentMarks(*//*12, "vyshnav", "trivandrum", 34, 43, 23, 0, 0.0*//*);
studentMarks.RollNumber = 1;
studentMarks.StudentName = "Test";
studentMarks.City = "Test";
studentMarks.FirstMark = 24;
studentMarks.SecondMark = 25;
studentMarks.ThirdMark = 26;
studentMarks.DisplayStudentDetails();
Console.WriteLine("Total marks:{0}",studentMarks.CalculateTotal());
Console.WriteLine("Average:{0}",studentMarks.CalculateAverage());  */

/*StudentGrade studentGrade=new StudentGrade();
studentGrade.RollNumber = 1;
studentGrade.StudentName = "vyshnav";
studentGrade.FirstMark = 95;
studentGrade.SecondMark = 94;
studentGrade.ThirdMark = 98;
studentGrade.DisplayStudentDetails();
Console.WriteLine("Total marks:{0}", studentGrade.CalculateTotal());
Console.WriteLine("Average:{0}", studentGrade.CalculateAverage());
Console.WriteLine("Grade:{0}",studentGrade.CalculateGrade());*/

/*Console.WriteLine("1.Teaching staff\n2.Non Teaching Staff\nchoose an option");
int option=Convert.ToInt32(Console.ReadLine());
switch (option)
{
    case 1: TeachingStaff teachingStaff = new TeachingStaff();
        teachingStaff.StaffId = 111;
        teachingStaff.StaffName = "vyshnav";
        teachingStaff.Department = "MCA";
        teachingStaff.Semester = 3;
        teachingStaff.Specialisation = "DBMS";
        teachingStaff.CollegeId = 1;
        teachingStaff.CollegeName = "CET";
        teachingStaff.DisplayCollegeDeatails();
        teachingStaff.DisplayStaffDetails();
        teachingStaff.DisplayTeachingStaffDetails();
        break;
    case 2: NonTeachingStaff nonTeachingStaff = new NonTeachingStaff();
        nonTeachingStaff.StaffId = 112;
        nonTeachingStaff.StaffName = "vishnu";
        nonTeachingStaff.Department = "MCA";
        nonTeachingStaff.Responsibilities = "Tech";
        nonTeachingStaff.Expirence = 5;
        nonTeachingStaff.CollegeId = 3;
        nonTeachingStaff.CollegeName = "CET";
        nonTeachingStaff.DisplayCollegeDeatails();
        nonTeachingStaff.DisplayStaffDetails() ;
        nonTeachingStaff.DisplayNonTeachingStaffDetails();
        break;
    default: Console.WriteLine("Invalid input");
        break;
}
*/
/*ElectricVehicle electricVehicle = new ElectricVehicle();
electricVehicle.VehicleNumber = 1111;
electricVehicle.Brand = "adsda";
electricVehicle.Model = "asads";
Console.WriteLine(electricVehicle.SetTypeForVehicle()); 

PetrolVehicle petrolVehicle = new PetrolVehicle();
petrolVehicle.VehicleNumber = 123;
petrolVehicle.Brand = "ssaddsa";
petrolVehicle.Model = "daadsdsa";
Console.WriteLine(petrolVehicle.SetTypeForVehicle()); 
*/

/*Doctor doctor = new Doctor();
doctor.AddNewDoctor();
doctor.DisplayDoctorDEtails();
doctor.ModifyDoctor();
doctor.DisplayDoctorDEtails();
doctor.BookApp(1,"IDJJDS");
doctor.DeleteAppoinment(1, "HDHDFS");*/

/*Bank bank = new  (12345, 412421421421L, "vyshnav", "active") ;
*//*Bank bank1 = new Bank();
Bank bank2 = new Bank(1234,12421342,"hdash");*//*
BankModified bankModified = new BankModified(12345, 412421421421L, "vyshnav", "active");
bankModified.WelcomeMessage();
while (true)
{
    Console.WriteLine("Enter your choice\n1.Customer id\n2.Account Number\n3.Name");
    int ch = Convert.ToInt32(Console.ReadLine());
    switch (ch)
    {

        case 1:
            Console.WriteLine("enter the customer id");
            int cusID = Convert.ToInt32(Console.ReadLine());
            bank.GetAccountDetails(cusID);
            break;
        case 2:
            Console.WriteLine("enter the Account Number");
            long Accountnum = Convert.ToInt64(Console.ReadLine());
            bank.GetAccountDetails(Accountnum);
            break;
        case 3:
            Console.WriteLine("enter Name");
            bank.GetAccountDetails(Console.ReadLine());
            break;
        default:
            Console.WriteLine("Invalid input");
            break;
    }
    Console.WriteLine("do you want to continue yes-press any key no-1");
    int option=Convert.ToInt32(Console.ReadLine());
    if (option == 1)
    {
        break;
    }
}*/
/*NonGenericCollections nonGenericCollections=new NonGenericCollections();
//nonGenericCollections.ArrayListHandling();
//nonGenericCollections.StackHandling();
//nonGenericCollections.QueueHandling();
//nonGenericCollections.HashTableHandling();
nonGenericCollections.SortedListHandling();*/
/*GenericCollection genericCollection = new GenericCollection();
genericCollection.ListHandling();
genericCollection.StackHandling();
genericCollection.DictionaryHandling();*/

/*ExceptionHandling exceptionHandling=new ExceptionHandling(15,45);
//exceptionHandling.Divide();
try
{
    exceptionHandling.numcheck();
}
catch(NumberOneException numExcep)
{
    Console.WriteLine(numExcep.Message);
}*/
/*using BasicPrograms;

FileOperation fileOperation = new FileOperation();
*//*fileOperation.CreateFile();
fileOperation.WriteData();*//*
//fileOperation.ReadData();
//fileOperation.CopyMoveFile();
fileOperation.FileProperties();*/

using BasicPrograms;

/*GenEx<int> genEx = new GenEx<int>(12,12);
Console.WriteLine(genEx.Val1+"\t"+genEx.Val2);

GenEx<double> genEx1 = new GenEx<double>(12.5, 15.4);
Console.WriteLine(genEx1.Val1 + "\t" + genEx1.Val2);

GenEx<string> genEx2 = new GenEx<string>("Vyshnav","KC");
Console.WriteLine(genEx2.Val1 + " " + genEx2.Val2);*/

GenEx<int> genEx3 = new GenEx<int>(new int[] { 1, 2, 3, 4 });
genEx3.Display();
