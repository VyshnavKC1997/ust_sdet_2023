// See https://aka.ms/new-console-template for more information
using Assignment_2_oct_19_Q2;

Student[] student=new Student[3];
for (int j = 0;j < 3;j++)
{
    Console.WriteLine("Enter full name");
    string? name=Console.ReadLine();
    Console.WriteLine("Enter marks");
    int[] marks=new int[3];
   
    for(int i = 0; i < marks.Length; i++)
    {
        Console.WriteLine("Enter mark for subject {0}",i+1);
        marks[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Enter the grade");
    char grade=Convert.ToChar(Console.ReadLine());
    student[j] = new Student(name,marks,grade);
}
for (int j = 0; j < 3; j++)
{
    student[j].DisplayStudent();
    student[j].GetMarkSummary();
}