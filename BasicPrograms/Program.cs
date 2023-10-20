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


using BasicPrograms;

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

Console.WriteLine("1.Teaching staff\n2.Non Teaching Staff\nchoose an option");
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


