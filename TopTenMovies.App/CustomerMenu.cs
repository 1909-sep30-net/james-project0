using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    class CustomerMenu
    {
        public void OpenCustomerMenu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Top Ten Video Store\n");

                Console.WriteLine("1. New Customer");
                Console.WriteLine("2. Current Customer");
                Console.WriteLine("3. Return To Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        //AddCustomer addCustomer = new AddCustomer();
                        //addCustomer.AddNewCustomer();
                        AddCustomerDB addCustomerDB = new AddCustomerDB();
                        addCustomerDB.AddNewCustomerDB();
                        break;

                    case "2":
                        CurrentCustomerMenu();
                        break;

                    case "3":
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.OpenMainMenu();
                        break;

                    default:
                        break;
                }

                void CurrentCustomerMenu()
                {
                    Console.Clear();
                    Console.WriteLine("Top Ten Video Store\n");

                    Console.WriteLine("1. Place New Order");
                    Console.WriteLine("2. View Order History");
                    Console.WriteLine("3. Return To Main Menu");
                    Console.WriteLine("\nPlease Choose: ");

                    var menuChoice = Console.ReadLine();

                    switch (menuChoice)
                    {
                        case "1":
                            NewOrder newOrder = new NewOrder();
                            newOrder.PlaceNewOrder();
                            break;

                        case "2":                          
                            var orderHistory = new AllOrdersByCustomer();
                            orderHistory.GetAllOrdersbyCustomer();
                            break;

                        case "3":
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
}
