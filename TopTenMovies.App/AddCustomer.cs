using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenMovies.App
{
    class AddCustomer
    {
        public void AddNewCustomer()
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
                    NewCustomer();
                    break;

                case "2":
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.OpenMainMenu();
                    break;

                default:
                    break;
            }
        }

        void NewCustomer()
        {
            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            //enter new customer data

            Console.WriteLine("TODO (enter to return to menu");
            var tempUI = Console.ReadLine();

            MainMenu mainMenu = new MainMenu();
            mainMenu.OpenMainMenu();
        }
    }
}
