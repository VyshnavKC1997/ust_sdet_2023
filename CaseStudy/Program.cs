// See https://aka.ms/new-console-template for more information
using CaseStudy;

Book[] bookArray = new Book[10];
Order order = new Order();
while (true) {
    int flag = 0,flag1=0;
    Console.WriteLine("\n\n*********BookStore******\n\n");
    Console.WriteLine("\n1.Add Book\n2.Add customer\n3.Search book\n4.Order book\n5.Order details\n6.Exit");
int option=Convert.ToInt32(Console.ReadLine());
    if (option == 6)
    {
        break;
    }

int i = 0;
    switch (option)
    {
        case 1:
            Book book = new Book();
            Console.WriteLine("Add book name");
            book.Title = Console.ReadLine();
            Console.WriteLine("Enter The author name");
            book.Authors = Console.ReadLine();
            Console.WriteLine("Enter ISBN");
            book.Isbn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price");
            book.Price= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter availability (yes-1)(no-2)");
            int avail = Convert.ToInt32(Console.ReadLine());
            if (avail == 1)
                book.Availability = true;
            else if (avail == 2)
                book.Availability = false;
            else
                Console.WriteLine("Invalid input");
            Console.WriteLine("Enter the Type");
            book.TypeOfBook = Console.ReadLine();
            bookArray[i] = book;
            i++;
            break;
        case 2:Customer customer = new Customer();
            Console.WriteLine("Enter customer id");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter customer Name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter Customer details");
            customer.ContactDetails= Console.ReadLine();
            Console.WriteLine("Do you want to view Customer Details 1-yes 2-no");
            int option2=Convert.ToInt32(Console.ReadLine());
            if (option2 == 1)
                customer.DisplayCustomer();
            else if (option2 == 2)
                break;
            break;
        case 3: Console.WriteLine("Enter the Book ISBN to Search");
                int num=Convert.ToInt32(Console.ReadLine());
          
                for(int j = 0; j < 10; j++)
            {
                if (bookArray[i] != null) {
                    if (bookArray[i].Isbn == num)
                    {
                        flag = 1;
                        bookArray[i].DisplayBook();
                        break;
                    }
                
                }
                
            }
            if (flag == 0)
            {
                Console.WriteLine("Book not found");
            }
            break;
            case 4:
            Console.WriteLine("Enter the ISBN ID to order");
            int isbnid=Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < 10; j++)
            {
                if (bookArray[i] != null)
                {
                    if (bookArray[i].Isbn == isbnid)
                    {
                        flag1 = 1;
                        bookArray[i].DisplayBook();
                        order.totalCost = bookArray[i].Price;
                        order.listOfBooks = bookArray[i];
                        Console.WriteLine("Enter the date");
                        order.orderDate=Console.ReadLine();
                        Console.WriteLine("Book ordered Successfully");
                        break;
                    }

                }

            }
            if(flag1==0)
                Console.WriteLine("Book Not Found");
            break;
            case 5:
            Console.WriteLine("order details are");
            order.DisplayOrder();
            break;



    }
}