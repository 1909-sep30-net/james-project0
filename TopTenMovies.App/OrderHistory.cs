using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    class OrderHistory
    {
        public void GetOrderHistory()
        {
            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            Console.WriteLine("Enter Customer Name: ");

            string name = Console.ReadLine();

            string[] customerName = name.Split(' ');

            string firstName = customerName[0];
            string lastName = customerName[1];

            var orderHistory = new OrderHistoryDB();
            orderHistory.GetOrderHistoryDB(firstName, lastName);
        }
    }
}
