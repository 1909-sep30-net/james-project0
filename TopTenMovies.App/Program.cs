using System;

namespace TopTenMovies.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Top Ten Video Store\n");

            while (true)
            {
                Console.WriteLine("1. Customer Menu");
                Console.WriteLine("2. Employee Menu");
                Console.WriteLine("3. Quit Application\n");
                Console.WriteLine("Please Choose: ");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        CustomerMenu cMenu = new CustomerMenu();
                        cMenu.OpenCustomerMenu();
                        break;

                    case "2":
                        ManagementMenu mMenu = new ManagementMenu();
                        mMenu.OpenManagementMenu();
                        break;

                    case "3":
                        Console.WriteLine("Exit.");
                        Environment.Exit(0);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
