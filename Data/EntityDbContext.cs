using Microsoft.EntityFrameworkCore;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class EntityDbContext : DbContext
    {
        public DbSet<RestaurantEntity> Restaurants { get; set; }
        public DbSet<DishEntity> Dishes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=127.0.0.1;initial catalog=Restaurant;User ID=sa;Password=123456;");
        }
    }
}
