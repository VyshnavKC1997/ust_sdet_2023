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

/*for (int i = 0; i < 3; i++)
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
}*/

/*for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter the record Id");
    int recordId = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Enter patient Name");
    string? name = Console.ReadLine();
   
    Console.WriteLine("Enter Diagnosis");
    string? diagnosis = Console.ReadLine();

    Console.WriteLine("enter the treatment cost");
    double treatmentCost = Convert.ToDouble(Console.ReadLine());

    MedicalRecord medicalRecord = new MedicalRecord();
    try
    {
        medicalRecord.AddMedicalRecord(recordId, name, diagnosis, treatmentCost);
    }
    catch (InvalidMedicalRecordException exe)
    {
        Console.WriteLine(exe.Message);
    }
    catch(InvalidPatientException exe2)
    {
        Console.WriteLine(exe2.Message);
    }
}
*/

/*while (true)
{

    Console.WriteLine("choose your option\n1.Add patient\n2.View patient");
    int option = Convert.ToInt32(Console.ReadLine());
    FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Documents\\vy\\Patient.txt",
          FileMode.Append, FileAccess.Write);
    StreamWriter writer = new StreamWriter(fileStream);
   
    switch (option)
    {

        case 1:

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
                    patient.GetPatient(patientId, age, name, diagnosis);
                }
                catch (PatientException exe)
                {
                    Console.WriteLine(exe.Message);
                }


                writer.WriteLine("Patient id:{0}\tPatient Name:{1}\tAge:{2}\tDiagnosis:{3}", patientId, name, age, diagnosis);
            
            break;
        case 2:
            writer.Close();
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Documents\\vy\\Patient.txt",
                  FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            break;
        default:
            Console.WriteLine("invalid input");
           
            break;
    }
    writer.Close();
  
    Console.WriteLine("do you want to continue\n1.yes\n2.no");
    int opt=Convert.ToInt32(Console.ReadLine());
    if(opt==1)
    {
        continue;
    }
    else if(opt==2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("invalid input");
    }
}
*/
/*
while (true)
{
    Console.WriteLine("choose your option\n1.Add patient history\n2.View patient history");
    int option = Convert.ToInt32(Console.ReadLine());
    FileStream fileStream = new FileStream("C:\\Users\\Administrator\\Documents\\vy\\PatientRecord.txt",
          FileMode.Append, FileAccess.Write);
    StreamWriter writer = new StreamWriter(fileStream);
    switch (option)
    {

        case 1:

            Console.WriteLine("Enter Record id");
            int recordId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Patient Id");
            int patientId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the age");
            string? description =Console.ReadLine();
            Console.WriteLine("Enter date");
            string? date = Console.ReadLine();

             MedicalHistory history = new MedicalHistory();
            try
            {
               history.AddHistory(recordId,patientId,description,date);
            }
            catch (PatientException exe)
            {
                Console.WriteLine(exe.Message);
            }


            writer.WriteLine("Record id:{0}\tPatient Id:{1}\tDescription:{2}\tDate:{3}",recordId,patientId,description,date);

            break;
        case 2:
            writer.Close();
            FileStream fs = new FileStream("C:\\Users\\Administrator\\Documents\\vy\\PatientRecord.txt",
                  FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string? str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
            break;
        default:
            Console.WriteLine("invalid input");

            break;
    }
    writer.Close();

    Console.WriteLine("do you want to continue\n1.yes\n2.no");
    int opt = Convert.ToInt32(Console.ReadLine());
    if (opt == 1)
    {
        continue;
    }
    else if (opt == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("invalid input");
    }

}*/
/*
HotelReservation<HotelRoom> hotelReservation = new HotelReservation<HotelRoom>();

while (true)
{
    Console.WriteLine("choose option \n1.Bookroom \n2.cancel room");
    int option = Convert.ToInt32(Console.ReadLine());
    if (option == 1)
    {
        Console.WriteLine("Enter the room number");
        int roomnumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter room type");
        string? roomtype = Console.ReadLine();
        HotelRoom room = new HotelRoom();
        room.IsBooked = true;
        room.RoomType = roomtype;
        room.RoomNumber = roomnumber;
        hotelReservation.BookRoom(room);
    }
    else if (option == 2)
    {
        Console.WriteLine("Enter the room number to cancel");
        int roomnumberCancel= Convert.ToInt32(Console.ReadLine());
       HotelRoom roomobj= HotelReservation<HotelRoom>.listOfHotelRoom.Find(x=> x.RoomNumber == roomnumberCancel); 
       if( roomobj != null )
        {
            hotelReservation.CancelRoom(roomobj);
        }
        else
        {
            Console.WriteLine("room is not booked");
        }
    }
    else
    {
        Console.WriteLine("invalid");
    }
    Console.WriteLine("Do you want to continue \n1.yes\n2.no");
    int exitoption= Convert.ToInt32(Console.ReadLine());
    if(exitoption == 1)
    {
        continue;
    }
    else if(exitoption == 2)
    {
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine("Invalid option");
    }
}*/

/*HotelRoom room1 = new HotelRoom();
room1.IsBooked = true;
room1.RoomType = "Double";
room1.RoomNumber = 2;

HotelRoom room2 = new HotelRoom();
room2.IsBooked = true;
room2.RoomType = "Double";
room2.RoomNumber = 3;*/

/*class Program
{
    public delegate double bonusCalculation(EmployeeClass employee);
    public static void Main(string[] args)
    {
        EmployeeClass employee = new EmployeeClass(1,"vyshnav",3.5);
        EmployeeClass employee1 = new EmployeeClass(2, "vishnu", 4.2);
        EmployeeClass employee2 = new EmployeeClass(3, "vikas", 4.1);
        bonusCalculation bonus = EmployeeClass.BonusCalc;
        bonusCalculation bonus2 = EmployeeClass.BonusCalcAccount;
        Console.WriteLine("Id:{0}\tName:{1}\tPerformance:{2}\tNormal bonus:{3}\tOnam bonus:{4}",employee.EmployeeId,
            employee.EmployeeName,employee.PerformanceRating,bonus(employee),bonus2(employee));
        Console.WriteLine("Id:{0}\tName:{1}\tPerformance:{2}\tNormal bonus:{3}\tOnam bonus:{4}", employee1.EmployeeId,
          employee1.EmployeeName, employee1.PerformanceRating, bonus(employee1), bonus2(employee1));
        Console.WriteLine("Id:{0}\tName:{1}\tPerformance:{2}\tNormal bonus:{3}\tOnam bonus:{4}", employee2.EmployeeId,
         employee2.EmployeeName, employee2.PerformanceRating, bonus(employee2), bonus2(employee2));
    }
}*/

/*class Program
{
    static int capacity = 1998;
    public delegate void EventDelegate(HotelEvent hotel);
    public static void Main(string[] args)
    {
        while (true)
        {
            HotelEvent hotelEvent = new HotelEvent();
            Console.WriteLine("Enter the Event Name");
            string? eventName = Console.ReadLine();
            Console.WriteLine("Enter Event Date");
            string? eventDate = Console.ReadLine();
            Console.WriteLine("Enter the Event Location");
            string? eventLocation = Console.ReadLine();
            hotelEvent.EventName = eventName;
            hotelEvent.EventDate = eventDate;   
            hotelEvent.Location = eventLocation;
            hotelEvent.Capacity = capacity; 
            if (capacity < 2000)
            {
                EventDelegate eventDelegate = HotelEvent.PrintRegisterationDetails;
                eventDelegate(hotelEvent);
                capacity++;
            }
            else
            {
                EventDelegate eventDelegate = HotelEvent.CapacityFull;
                eventDelegate(hotelEvent);
            }
            Thread.Sleep(2000);
            Console.WriteLine("do you want to register another user\nyes-1\nno-2");
            int option=Convert.ToInt32(Console.ReadLine());
            if(option == 1)
            {
                continue;
            }
            else if (option == 2)
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("invalid option");
            }
        }
    }
}*/

/*List<TourismDestination> tourismDestinations = new List<TourismDestination>();
TourismDestination tourism = new("name", "india", 3.8);
TourismDestination tourism1 = new("name1", "india", 3.6);
TourismDestination tourism2 = new("name2", "UK", 4.2);
TourismDestination tourism3 = new("name3", "UAE", 2.3);
TourismDestination tourism4= new("name4", "america", 3.3);

tourismDestinations.Add(tourism);
tourismDestinations.Add(tourism1);
tourismDestinations.Add(tourism2);
tourismDestinations.Add(tourism3);
tourismDestinations.Add(tourism4);
tourism.SortListOfTour(tourismDestinations);*/

/*
TourismDestinationSecond tourism = new("name", "india", 3.8,4000);
TourismDestinationSecond tourism1 = new("name1", "india", 3.6, 3000);
TourismDestinationSecond tourism2 = new("name2", "UK", 4.2,10000);
TourismDestinationSecond tourism3 = new("name3", "UAE", 2.3,1200);
TourismDestinationSecond tourism4 = new("name4", "america", 3.3,1100);

TourismDestinationSecond.tourismDestinations.Add(tourism);
TourismDestinationSecond.tourismDestinations.Add(tourism1);
TourismDestinationSecond.tourismDestinations.Add(tourism2);
TourismDestinationSecond.tourismDestinations.Add(tourism3);
TourismDestinationSecond.tourismDestinations.Add(tourism4);

Console.WriteLine("Enter the rating to search");
double ar=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("top rated destination are");
tourism.TopRatedDestination(ar);
Console.WriteLine("list in ascending order");
tourism.SortingWithPrice();
Console.WriteLine("Enter city Name to filter");
string? city=Console.ReadLine();
Console.WriteLine("Tourist destination in {0}", city);
tourism.FilterWithCityName(city);*/


/*Hotel hotel = new Hotel("name",4,"ars","adfgas",45);
Hotel hotel1 = new Hotel("nam3", 6, "ars", "adfgas", 45);
Hotel hotel2 = new Hotel("name6", 17, "ars", "adfgas", 45);

await hotel.HotelBookingig(3);
await hotel1.HotelBookingig(7);
await hotel2.HotelBookingig(7);*/

/*TourPackage package=new TourPackage(1,"kochi","12-1-2025",1200);
TourPackage package1 = new TourPackage(2, "alappuzha", "12-1-2024", 1400);
TourPackage package2 = new TourPackage(3, "kannur", "12-12-2023", 1500);

TourPackage.TourPackages.Add(package1);
TourPackage.TourPackages.Add(package2);
TourPackage.TourPackages.Add(package);


Thread thread = new Thread(TourPackage.HotelReservation);

Thread thread1 = new Thread(TourPackage.HotelReservation);

thread1.Start();
thread1.Join();
thread.Start();*/


TaskItem ts= new TaskItem(1,"study",false);
TaskItem ts1 = new TaskItem(2, "play", true);
TaskItem ts2 = new TaskItem(3, "gym", true);
TaskItem ts3 = new TaskItem(4, "work", false);

TaskItem.TaskItems.Add(ts);
TaskItem.TaskItems.Add(ts1);
TaskItem.TaskItems.Add(ts2);
TaskItem.TaskItems.Add(ts3);

Console.WriteLine("Do you want to change the status of task enter the id to change");
int id=Convert.ToInt32(Console.ReadLine()); 
var changeObj=TaskItem.TaskItems.Find(x=>x.TaskId==id);
if (changeObj != null)
{
    changeObj.IsCompleted = true;
    Console.WriteLine("changed the status as completed");
}
else
    Console.WriteLine("id not found");
Console.WriteLine("Enter the id to remove Task");
int rem=Convert.ToInt32(Console.ReadLine());
TaskItem.TaskItems.RemoveAll(x=>x.TaskId==rem);
Console.WriteLine("Task removed succeessfully");

Console.WriteLine("Total Tasks Are");
TaskItem.FilteringTask();