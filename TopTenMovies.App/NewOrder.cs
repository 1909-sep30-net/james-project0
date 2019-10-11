using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenMovies.App
{
    class NewOrder
    {
        public void PlaceNewOrder()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Top Ten Video Store\n");

                Console.WriteLine("1. ");
                Console.WriteLine("2. ");
                Console.WriteLine("3. Return to Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":

                        break;

                    case "2":

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
