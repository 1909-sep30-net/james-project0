using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    public class AllOrdersByLocation
    {
        public void GetOrdersByLocation()
        {
            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");
            Console.WriteLine("All Locations:");

            var allLocations = new AllLocations();
            allLocations.GetAllLocations();

            Console.WriteLine("\nEnter LocationID for All Orders at Location");
            int locationID = Int32.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");

            var allOrdersAtLocation = new OrdersByLocationDB();
            allOrdersAtLocation.GetOrdersByLocationDB(locationID);

        }
    }
}
