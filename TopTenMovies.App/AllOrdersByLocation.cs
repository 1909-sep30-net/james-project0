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
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Top Ten Video Store\n");
                Console.WriteLine("All Locations:");

                var allLocations = new AllLocations();
                allLocations.GetAllLocations();

                Console.WriteLine("\nEnter LocationID for All Orders at Location");
                string inputLocationID = Console.ReadLine();

                if(!(string.IsNullOrEmpty(inputLocationID)))
                {
                    int locationID = int.Parse(inputLocationID);
                    Console.Clear();
                    Console.WriteLine("Top Ten Video Store\n");

                    var allOrdersAtLocation = new OrdersByLocationDB();
                    allOrdersAtLocation.GetOrdersByLocationDB(locationID);

                    break;
                }

                Console.WriteLine("\n Invalid Input.");
                Console.WriteLine("\n Hit any Key to Continue");
                Console.ReadKey();
            }
        }
    }
}
