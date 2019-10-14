using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using System.Linq;

namespace TopTenMovies.DataAccess
{
    public class AddInventoryDB
    {
        public void AddNewInventoryDB(string filmTitle, string filmPrice)
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new TopTenMoviesContext(options);

            var product = new Product();

            product.Title = filmTitle;
            product.Price = decimal.Parse(filmPrice);

            context.Product.Add(product);

            context.SaveChanges();

            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");
            Console.WriteLine($"{product.Title} ${product.Price} Added.\n");
            Console.WriteLine("Hit any Key to Continue: ");
            Console.ReadKey();
        }

    }
}
