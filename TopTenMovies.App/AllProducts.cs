using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    public class AllProducts
    {
        public void GetAllProducts()
        {
            var displayAllProducts = new AllProductsDB();
            displayAllProducts.GetAllProducts();
        }
    }
}
