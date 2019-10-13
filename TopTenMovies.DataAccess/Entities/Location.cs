using System;
using System.Collections.Generic;

namespace TopTenMovies.DataAccess.Entities
{
    public partial class Location
    {
        public Location()
        {
            Orders = new HashSet<Orders>();
        }

        public int LocationId { get; set; }
        public string City { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public virtual Product Product { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
