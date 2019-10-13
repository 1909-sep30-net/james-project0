using System;
using System.Collections.Generic;

namespace TopTenMovies.DataAccess.Entities
{
    public partial class Product
    {
        public Product()
        {
            Location = new HashSet<Location>();
            Orders = new HashSet<Orders>();
        }

        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<Location> Location { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
