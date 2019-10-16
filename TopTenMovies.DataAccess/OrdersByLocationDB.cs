using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using System.Linq;


namespace TopTenMovies.DataAccess
{
    public class OrdersByLocationDB
    {
        public void GetOrdersByLocationDB(int locationID)
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new TopTenMoviesContext(options);
            using var context2 = new TopTenMoviesContext(options);
            using var context3 = new TopTenMoviesContext(options);

            int count = 0;

            foreach (Orders order in context.Orders)
            {
                var title = context2.Product.FirstOrDefault(p => p.ProductId == order.ProductId);
                var location = context3.Location.FirstOrDefault(p => p.LocationId == order.LocationId);

                if (order.LocationId == locationID)
                {
                    count++;

                    Console.WriteLine($"[LocationID] {order.LocationId} [Location] {location.City} [Title] {title.Title} " +
                        $"[Quantity] {order.Quantity}");
                }
            }
            if(count == 0)
            {
                Console.WriteLine("\nNo Orders at this Location");
                Console.WriteLine("\nHit any Key to Continue");
                Console.ReadKey();
            }
        }
    }
}
