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

                Console.WriteLine("1. View All Orders by Customer");
                Console.WriteLine("2. View All Orders by Location");
                Console.WriteLine("3. Search For Customer By Name");
                Console.WriteLine("4. Search for Order By Number");
                Console.WriteLine("5. Add New Customer");
                Console.WriteLine("6. Place New Order");
                Console.WriteLine("7. View All Customers");
                Console.WriteLine("8. Add Inventory");
                Console.WriteLine("9. Return to Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        //View All Orders
                        var allOrders = new AllOrdersByCustomer();
                        allOrders.GetAllOrdersbyCustomer();
                        break;

                    case "2":
                        //View All Customers
                        var allOrdersByLocation = new AllOrdersByLocation();
                        allOrdersByLocation.GetOrdersByLocation();
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
                        //View all Customers
                        var allCustomers = new AllCustomers();
                        allCustomers.GetAllCustomers();
                        break;

                    case "8":
                        //Add Inventory
                        var addInventory = new AddInventory();
                        addInventory.AddNewInventory();    
                        break;

                    case "9":
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
