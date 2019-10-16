using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    class AddCustomer
    {
        public void AddNewCustomer()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Top Ten Video Store\n");
                Console.WriteLine("1. Enter New Customer Info");
                Console.WriteLine("2. Return to Main Menu");

                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        AddCustomerDB addCustomerDB = new AddCustomerDB();
                        addCustomerDB.AddNewCustomerDB();
                        break;

                    case "2":
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
