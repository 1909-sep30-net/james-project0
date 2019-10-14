using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    class CustomerSearch
    {
        public void SearchCustomers()
        {
            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            Console.WriteLine("Enter Customer Name: First and Last");

            string customerName = Console.ReadLine();

            string[] fullName = customerName.Split(' ');

            string firstName = fullName[0];
            string lastName = fullName[1];

            var searchCustomer = new SearchCustomerDB();
            searchCustomer.SearchForCustomerDB(firstName, lastName);

            Console.WriteLine("\nHit Any Key to Continue: ");
            Console.ReadKey();
        }
    }
}
