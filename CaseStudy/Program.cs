// See https://aka.ms/new-console-template for more information
/*using CaseStudy;

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
}*/
using CaseStudy;

Customer1 customer11 = new Customer1();
customer11.CustomerID = 1;
customer11.CustomerName = "Vyshnav";
customer11.CustomerEmail = "vyshnav@ust";
Customer1.customers.Add(customer11);
Customer1 customer12 = new Customer1();
customer12.CustomerID = 2;
customer12.CustomerName = "vishnu";
customer12.CustomerEmail = "vishnu@ust";
Customer1.customers.Add(customer12);
Customer1 customer13 = new Customer1();
customer13.CustomerID = 3;
customer13.CustomerName = "vikas";
customer13.CustomerEmail = "vikas@ust";
Customer1.customers.Add(customer13);

while (true)
{
    Console.Clear();
    Console.WriteLine("choose your option\n1.User\n2.Admin");
    int option = Convert.ToInt32(Console.ReadLine());
  
        if (option == 1)

        {
            Console.Clear() ;
            Console.WriteLine("Enter the customer id");
            int cusId = Convert.ToInt32(Console.ReadLine());
            if (Customer1.customers.Find(x => x.CustomerID == cusId) == null)
            {
                Console.Clear();
                Console.WriteLine("Customer not found");
                break;
            }
        while (true)
        {
            Console.Clear();
            Console.WriteLine("choose your option\n1.Add product to cart\n2.view all product\n3.place order\n4.Support\n5.view orders");
            int optionuser = Convert.ToInt32(Console.ReadLine());
        
            switch (optionuser)
            {

                case 1:
                    Console.Clear();
                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                    {
                        Console.WriteLine("No Product Found found");
                    }
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.Clear();
                        Console.WriteLine("products are");
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in PhysicalProduct.Products)
                    {
                        Console.Clear();
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                            "\tDimension:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                    }
                    Console.WriteLine("Enter Product id for add to cart");
                    int productId = Convert.ToInt32(Console.ReadLine());
                    Customer1 customer1 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (DigitalProduct.Products.Find(x => x.ProductId == productId) == null)
                    {
                        if (PhysicalProduct.Products.Find(x => x.ProductId == productId) == null)
                        {
                            Console.Clear();
                            Console.WriteLine("invalid product id");
                        }
                        else
                        {
                            Console.Clear();
                            customer1.ordersphy.Add(PhysicalProduct.Products.Find(x => x.ProductId == productId));
                            Console.WriteLine("product added to cart");
                        }
                    }
                    else
                    {
                        Console.Clear();
                        customer1.orders.Add(DigitalProduct.Products.Find(x => x.ProductId == productId));
                        Console.WriteLine("product added to cart");
                    }
                    break;
                case 2:
                    Console.Clear();    
                    Console.WriteLine("Products are");
                    if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                    {
                        Console.WriteLine("No Product Found found");
                    }
                    foreach (var item in DigitalProduct.Products)
                    {
                        Console.Clear();
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                    }
                    foreach (var item in PhysicalProduct.Products)
                    {
                        
                        Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                            "\tDimension:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                    }
                    break;
                case 3:
                    Customer1 customer = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer.orders.Count == 0 && customer.ordersphy.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("no product found in cart");
                    }
                    else
                    {
                        foreach (var item in customer.orders)
                        {
                            Thread.Sleep(3000);
                            Console.Clear();
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                             item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                            item.PlacingOrder();
                            item.ProcessingPayment();
                            item.DeliveringProduct();
                            
                        }
                        foreach (var item in customer.ordersphy)
                        {
                           
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId,
                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                            item.PlacingOrder();
                            item.ProcessingPayment();
                            item.DeliveringProduct();
                        }
                          
                        Console.WriteLine("do you want to confirm all transaction and move to main menu\n1.yes\n2.no");
                        int confirm = Convert.ToInt32(Console.ReadLine());
                        if (confirm == 1)
                        {
                            customer.confirmedorders.AddRange(customer.orders);
                            customer.orders.Clear();
                            customer.confirmedordersphy.AddRange(customer.ordersphy);
                            customer.ordersphy.Clear();
                            Console.Clear();
                            Console.WriteLine("order placed successfully");
                        }
                        else
                        {
                            Console.Clear();    
                            Console.WriteLine("removing everything in cart");
                        }


                    }



                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("call this number for support 96456636727");
                    break;
                case 5:
                    Customer1 customer2 = Customer1.customers.Find(x => x.CustomerID == cusId);
                    if (customer2.confirmedorders.Count == 0 && customer2.confirmedordersphy.Count == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("no order details found");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Orders are");
                        foreach (var item in customer2.confirmedorders)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                            item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                        }
                        foreach (var item in customer2.confirmedordersphy)
                        {
                            Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                           "\tDimension:{5}", item.ProductId,
                           item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                        }
                    }
                    break;
                default:
                    Console.Clear ();
                    Console.WriteLine("invalid input");

                    break;
            }
         
            Console.WriteLine("do you want to continue as user\n1.yes\n2.no");
            int optuser = Convert.ToInt32(Console.ReadLine());
            if (optuser == 1)
            {
                continue;
            }
            else if (optuser == 2)
            {
                break;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("invalid input");
            }
        }


        }
    
        else if (option == 2)
        {
        Console.Clear();
        Console.WriteLine("choose option\n1.Add Product\n2.view report");
        int optionadmin=Convert.ToInt32(Console.ReadLine());
        if(optionadmin == 1)
        {
            Console.Clear();
            Console.WriteLine("choose the option \n1.Digital Product\n2.Physical Product");
            int optionProduct=Convert.ToInt32(Console.ReadLine());
            if(optionProduct == 1)
            {
                Console.Clear();
                Console.WriteLine("Enter Product id");
                int productid=Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine("Enter Product Name");
                string? productName=Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost=Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the fileformat");
                string? fileFormat=Console.ReadLine();
                Console.WriteLine("Enter downloadLink");
                string? downloadLink=Console.ReadLine();
                Console.WriteLine("Enter the Quantity");
                int quantity=Convert.ToInt32(Console.ReadLine());


                DigitalProduct digitalProduct = new DigitalProduct();
                digitalProduct.ProductName = productName;
                digitalProduct.ProductId = productid;
                digitalProduct.FileFormat = fileFormat;
                digitalProduct.DownloadLink = downloadLink;
                digitalProduct.Price = productCost;
                digitalProduct.ProductQuantity = quantity;
                DigitalProduct.Products.Add(digitalProduct);
            }
            else if(optionProduct==2)
            {
                Console.Clear();
                Console.WriteLine("Enter Product id");
                int productid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Product Name");
                string? productName = Console.ReadLine();
                Console.WriteLine("enter the price");
                double productCost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the Weight");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter dimension");
                string? dimension = Console.ReadLine();
                Console.WriteLine("Enter the Quantitys");
                int quantity = Convert.ToInt32(Console.ReadLine());

                PhysicalProduct physicalProduct = new PhysicalProduct();
                physicalProduct.ProductName = productName;
                physicalProduct.ProductId = productid;
                physicalProduct.Price = productCost;
                physicalProduct.Dimension = dimension;
                physicalProduct.Weight = weight;
                physicalProduct.ProductQuantity = quantity;


                PhysicalProduct.Products.Add(physicalProduct);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid");
            }
        }
        else if (optionadmin == 2)
        {
            Console.WriteLine("User list is ");
            foreach (var item1 in Customer1.customers)
            {

                Console.WriteLine("customer name:{0}", item1.CustomerName);
            }
                Console.WriteLine("Total product available are");
                if (DigitalProduct.Products.Count == 0 && PhysicalProduct.Products.Count == 0)
                {
                    Console.WriteLine("No Product Found found");
                }
                foreach (var item in DigitalProduct.Products)
                {
                  
                    Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tFileFormat:{4}\tDownloadlink:{5}", item.ProductId,
                        item.ProductName, item.Price, item.ProductQuantity, item.FileFormat, item.DownloadLink);
                }
                foreach (var item in PhysicalProduct.Products)
                {

                    Console.WriteLine("Productid:{0}\tProduct Name:{1}\tPrice:{2}\tProduct Quantity:{3}\tWeight:{4}" +
                        "\tDimension:{5}", item.ProductId,
                        item.ProductName, item.Price, item.ProductQuantity, item.ProductQuantity, item.Dimension);
                }
               
            
        }
    }


       
        else
        {
        Console.Clear();
            Console.WriteLine("invalid option");
        }
       
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
        Console.Clear();
            Console.WriteLine("invalid input");
        }
    
}
    


