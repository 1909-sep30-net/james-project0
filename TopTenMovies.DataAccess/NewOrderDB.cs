using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TopTenMovies.DataAccess.Entities;
using System.Linq;
using TopTenMovies.Library;

namespace TopTenMovies.DataAccess
{
    public class NewOrderDB
    {
        public void PlaceNewOrderDB(int filmProductId, int filmLocationId, int filmQuantityId)
        {
            string connectionString = SecretConfiguration.ConnectionString;

        DbContextOptions<TopTenMoviesContext> options = new DbContextOptionsBuilder<TopTenMoviesContext>()
            .UseSqlServer(connectionString)
            .Options;

            using var context = new TopTenMoviesContext(options);
}
    }
}
