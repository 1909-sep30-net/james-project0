using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    public class AllOrdersByCustomer
    {
        public void GetAllOrdersbyCustomer()
        {
            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            Console.WriteLine("Enter Customer Name: First and Last");

            string customerName = Console.ReadLine();

            string[] fullName = customerName.Split(' ');

            string firstName = fullName[0];
            string lastName = fullName[1];

            var getCustomerId = new CustomerIdDB();
            int customerId = getCustomerId.GetCustomerIdDB(firstName, lastName);

            if (customerId == 0)
            {
                Console.WriteLine("\nHit any Key to Return to Menu");
                Console.ReadKey();

                var mainMenu = new MainMenu();
                mainMenu.OpenMainMenu();
            }

            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");
            Console.WriteLine($"Order History for {firstName} {lastName}\n");

            var orderHistory = new OrdersByCustomerDB();
            orderHistory.GetOrdersByCustomerDB(customerId);

            Console.WriteLine("\nHit any Key to Continue");
            Console.ReadKey();
        }
    }
}
