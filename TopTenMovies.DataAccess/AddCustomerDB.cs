﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using System.Linq;

namespace TopTenMovies.DataAccess
{
    public class AddCustomerDB
    {
        public void AddNewCustomerDB()
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new TopTenMoviesContext(options);

            Customer newCustomer = new Customer();

            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");
            Console.WriteLine("Enter Customer First and Last Name: \n");

            string customerName = Console.ReadLine();

            string[] fullName = customerName.Split(' ');

            newCustomer.FirstName = fullName[0];
            newCustomer.LastName = fullName[1];

            context.Customer.Add(newCustomer);

            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");
            Console.WriteLine($"{newCustomer.FirstName} {newCustomer.LastName} Added.\n");
            Console.WriteLine("Hit Any Key to Continue.\n");
            Console.ReadLine();
        }
    }
}