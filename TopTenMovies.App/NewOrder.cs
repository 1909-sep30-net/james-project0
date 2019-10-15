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

            Console.WriteLine("Enter Customer Name: First and Last");

            string customerName = Console.ReadLine();

            string[] fullName = customerName.Split(' ');

            string firstName = fullName[0];
            string lastName = fullName[1];

            var getCustomerId = new CustomerIdDB();
            int customerId = getCustomerId.GetCustomerIdDB(firstName, lastName);

            if(customerId == 0)
            {
                Console.WriteLine("\nHit any Key to Return to Menu");
                Console.ReadKey();

                var mainMenu = new MainMenu();
                mainMenu.OpenMainMenu();
            }
            else
            {
                Console.WriteLine($"\n[CustomerId] {customerId}");
                Console.WriteLine("\nHit any Key to Continue Order");
                Console.ReadKey();
            }

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

            decimal orderTotal = (decimal)10.99 * filmQuantity;

            //call to NewOrderDB
            var newOrder = new NewOrderDB();
            newOrder.PlaceNewOrderDB(customerId, filmProductId, filmLocationId, filmQuantity, orderTotal);

            Console.Clear();
            Console.WriteLine("Top Ten Video Store\n");
            Console.WriteLine("Order Placed.");
            Console.WriteLine("\nHit any Key to Continue");
            Console.ReadKey();
        }
    }
}
