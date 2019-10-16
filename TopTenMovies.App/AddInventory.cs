using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    public class AddInventory
    {
        public void AddNewInventory()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Top Ten Video Store\n");

                Console.WriteLine("1. Add Inventory");
                Console.WriteLine("2. Return to Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Top Ten Video Store\n");

                        Console.WriteLine("Film Title: ");
                        string filmTitle = Console.ReadLine();

                        if(string.IsNullOrEmpty(filmTitle))
                        {
                            Console.WriteLine("\nInvalid Entry");
                            Console.WriteLine("\nHit any Key to Continue");
                            Console.ReadKey();
                            break;
                        }

                        Console.WriteLine("\nPrice: ");
                        string filmPrice = Console.ReadLine();

                        if (string.IsNullOrEmpty(filmPrice) || !decimal.TryParse(filmPrice, out decimal temp))
                        {
                            Console.WriteLine("\nInvalid Entry: Decimal Format");
                            Console.WriteLine("\nHit any Key to Continue");
                            Console.ReadKey();
                            break;
                        }

                        var addInventory = new AddInventoryDB();
                        addInventory.AddNewInventoryDB(filmTitle, filmPrice);

                        break;

                    case "2":
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.OpenMainMenu();
                        break;

                    default:
                        Console.WriteLine("\n Invalid Input.");
                        Console.WriteLine("\n Hit any Key to Continue");
                        Console.ReadKey();
                        break;
                }
            }
        }

    }
}
