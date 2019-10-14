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
                Console.WriteLine("3. Return to Main Menu");
                Console.WriteLine("\nPlease Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Top Ten Video Store\n");

                        Console.WriteLine("Film Title: ");
                        string filmTitle = Console.ReadLine();

                        Console.WriteLine("\nPrice: ");
                        string filmPrice = Console.ReadLine();

                        var addInventory = new AddInventoryDB();
                        addInventory.AddNewInventoryDB(filmTitle, filmPrice);

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
