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

                Console.WriteLine("1. Place New Order");
                Console.WriteLine("3. Return to Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Top Ten Video Store\n");

                        Console.WriteLine("Available Now: \n");

                        //display 10 choices

                        Console.WriteLine("\nEnter Title You Want to Purchase: ");
                        string filmTitle = Console.ReadLine();

                        Console.WriteLine("\nEnter Location for Pickup: ");
                        string filmLocation = Console.ReadLine();

                        //verify location inventory is not zero

                        Console.WriteLine("\nEnter Quantity you Wish to Purchase: ");
                        string filmQuantity = Console.ReadLine();

                        //verify inventory available

                        //call to NewOrderDB

                        Console.WriteLine("Hit any Key to Continue");
                        Console.ReadKey();

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
