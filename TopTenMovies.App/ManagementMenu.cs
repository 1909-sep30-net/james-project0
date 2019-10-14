using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenMovies.App
{
    class ManagementMenu
    {
        public void OpenManagementMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Top Ten Video Store\n");

                Console.WriteLine("1. View All Orders");
                Console.WriteLine("2. View All Customers");
                Console.WriteLine("3. Search For Customer By Name");
                Console.WriteLine("4. Search for Order By Number");
                Console.WriteLine("5. Add New Customer");
                Console.WriteLine("6. Place New Order");
                Console.WriteLine("7. View Order History By Location");
                Console.WriteLine("8. Return to Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        //View All Orders
                        AllOrders allOrders = new AllOrders();
                        allOrders.GetAllOrders();
                        break;

                    case "2":
                        //View All Customers
                        AllCustomers allCustomers = new AllCustomers();
                        allCustomers.GetAllCustomers();

                        Console.WriteLine("\nHit Any Key to Continue:");

                        Console.ReadKey();
                        break;

                    case "3":
                        //Search for Customer by Name
                        CustomerSearch customerSearch = new CustomerSearch();
                        customerSearch.SearchCustomers();
                        break;

                    case "4":
                        //Search for Order By Number
                        OrderSearch orderSearch = new OrderSearch();
                        orderSearch.SearchOrders();
                        break;

                    case "5":
                        //Add New Customer
                        AddCustomer addCustomer = new AddCustomer();
                        addCustomer.AddNewCustomer();
                        break;

                    case "6":
                        //Place New Order
                        NewOrder newOrder = new NewOrder();
                        newOrder.PlaceNewOrder();
                        break;

                    case "7":
                        //Get Order History by Location
                        OrderHistoryByLocation orderHistoryByLocation = new OrderHistoryByLocation();
                        orderHistoryByLocation.GetOrderHistory();
                        break;

                    case "8":
                        //Return to Main Menu
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.OpenMainMenu();
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
