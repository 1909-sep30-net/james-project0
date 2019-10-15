using System;
using System.Collections.Generic;
using System.Text;
using TopTenMovies.DataAccess;

namespace TopTenMovies.App
{
    public class AllLocations
    {
        public void GetAllLocations()
        {
            var allLocations = new AllLocationsDB();
            allLocations.GetAllLocationsDB();
        }
    }
}
