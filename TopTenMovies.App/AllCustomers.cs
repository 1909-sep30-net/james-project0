using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    class AllCustomers
    {
        public void GetAllCustomers()
        {
            var displayAllCustomers = new AllCustomersDB();
            displayAllCustomers.DisplayAllCustomers();
        }
    }
}
