using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace RestaurantRater.Models
{
    public class Restaurant
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double Rating { get; set; }
        public int RestaurantID { get; set; }
    }
    public class RestaurantDBContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}