using System;
using System.Collections.Generic;
using System.Text;

namespace TopTenMovies.App
{
    class CustomerMenu
    {
        public void OpenCustomerMenu()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("1. New Customer");
                Console.WriteLine("2. Current Customer");

                var menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        NewCustomerMenu();
                        break;

                    case "2":
                        CurrentCustomerMenu();
                        break;

                    default:
                        break;
                }

                void NewCustomerMenu()
                {
                    Console.Clear();
                }

                void CurrentCustomerMenu()
                {
                    Console.Clear();

                }
            }

           
        }

        

        


    }  
}
