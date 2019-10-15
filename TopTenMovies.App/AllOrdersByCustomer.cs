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

            var customerList = new AllCustomersDB();
            customerList.GetAllCustomersDB();

            Console.WriteLine("\nEnter Customer ID to View Order History: ");
            string customerId = Console.ReadLine();
            int customerID = int.Parse(customerId);

            Console.Clear();

            var orderHistory = new AllOrdersByCustomer();
            orderHistory.GetAllOrdersbyCustomer();

            Console.WriteLine("\nHit any Key to Continue");
            Console.ReadKey();
        }
    }
}
