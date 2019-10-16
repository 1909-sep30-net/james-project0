using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    class AllCustomers
    {
        public void GetAllCustomers()
        {
            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            var displayAllCustomers = new AllCustomersDB();
            displayAllCustomers.GetAllCustomersDB();

            Console.WriteLine("\nHit Any Key to Continue: ");
            Console.ReadKey();
        }
    }
}
