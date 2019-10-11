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

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        //View All Orders
                        break;

                    case "2":
                        //View All Customers
                        break;

                    case "3":
                        //Search for customer by name
                        break;

                    case "4":
                        //Search for Order By Number
                        break;

                    case "5":
                        //add new customer
                        break;

                    case "6":

                        break;

                    case "7":

                        break;

                    case "8":
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.OpenMainMenu();
                        break;

                    default:
                        break;
                }

                //void NewCustomerMenu()
                //{
                //    Console.Clear();
                //}

                //void CurrentCustomerMenu()
                //{
                //    Console.Clear();

                //}
            }
        }
    }
}
