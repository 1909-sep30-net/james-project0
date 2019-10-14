using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;

namespace TopTenMovies.DataAccess
{
    public class AllCustomersDB
    {
        public void DisplayAllCustomers()
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new TopTenMoviesContext(options);

            Console.Clear();

            foreach (Customer customer in context.Customer)
            {
                Console.WriteLine($"[CustomerId] {customer.CustomerId} [Customer Name] {customer.FirstName} {customer.LastName}");
            }
        }
    }
}
