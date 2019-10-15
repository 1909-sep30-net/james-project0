using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    class NewOrder
    {
        public void PlaceNewOrder()
        {
            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            Console.WriteLine("Available Now: \n");

            var allProducts = new AllProducts();
            allProducts.GetAllProducts();

            Console.WriteLine("\nEnter ProductId to Purchase: ");
            int filmProductId = Int32.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            var allLocations = new AllLocations();
            allLocations.GetAllLocations();

            Console.WriteLine("\nEnter Location (Id) for Order: ");
            int filmLocationId = Int32.Parse(Console.ReadLine());

            //verify location inventory is not zero

            Console.WriteLine("\nEnter Quantity you Wish to Purchase: ");
            int filmQuantity = Int32.Parse(Console.ReadLine());

            //verify inventory available

            //call to NewOrderDB
            var newOrder = new NewOrderDB();
            newOrder.PlaceNewOrderDB(filmProductId, filmLocationId, filmQuantity);


            Console.WriteLine("Order Placed.");
            Console.WriteLine("\nHit any Key to Continue");
            Console.ReadKey();
        }
    }
}
