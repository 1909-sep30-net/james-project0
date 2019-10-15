using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using System.Linq;

namespace TopTenMovies.DataAccess
{
    public class OrdersByCustomerDB
    {
        public void GetOrdersByCustomerDB(int customerID)
        {
            string connectionString = SecretConfiguration.ConnectionString;

            DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
                .UseSqlServer(connectionString)
                .Options;

            using var context = new TopTenMoviesContext(options);
            using var context2 = new TopTenMoviesContext(options);
            using var context3 = new TopTenMoviesContext(options);

            foreach (Orders order in context.Orders)
            {
                var title = context2.Product.FirstOrDefault(p => p.ProductId == order.ProductId);
                var location = context3.Location.FirstOrDefault(p => p.LocationId == order.LocationId);

                if (order.CustomerId == customerID)
                {
                    Console.WriteLine($"[CustomerId] {order.CustomerId} [Location] {location.City} [Title] {title.Title} " +
                        $"[Quantity] {order.Quantity}");
                }         
            }
        }
    }
}
