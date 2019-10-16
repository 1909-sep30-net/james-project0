using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;

namespace TopTenMovies.DataAccess
{
    public class AllLocationsDB
    {
        public void GetAllLocationsDB()
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new TopTenMoviesContext(options);

            foreach (Location location in context.Location)
            {
                Console.WriteLine($"[LocationId] {location.LocationId} [City] {location.City}");
            }
        }
    }
}
