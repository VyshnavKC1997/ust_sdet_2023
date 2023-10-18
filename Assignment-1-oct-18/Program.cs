// See https://aka.ms/new-console-template for more information
using Assignment_1_oct_18;

Console.WriteLine("enter the name");
string? name=Console.ReadLine();
Console.WriteLine("Enter the 3 marks");
int markOne=Convert.ToInt32(Console.ReadLine());
int markTwo = Convert.ToInt32(Console.ReadLine());
int markThree = Convert.ToInt32(Console.ReadLine());
Student student=new Student(name, markOne, markTwo, markThree);
Console.WriteLine("\nName :" + name +"\nTotal mark :"+student.TotalMark()+ "\nAverage:" + student.Average()+"\nGrade:"+student.TotalGrade());