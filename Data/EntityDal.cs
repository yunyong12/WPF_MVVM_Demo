using Microsoft.EntityFrameworkCore;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Data
{
    public class EntityDal
    {
        public static EntityDbContext context = new EntityDbContext();

        //查询餐馆信息
        public async static Task<List<RestaurantEntity>> GetRestaurantAsync()
        {
            return await context.Restaurants.ToListAsync();
        }

        public static List<RestaurantEntity> GetRestaurants()
        {
            return context.Restaurants.ToList();
        }

        //查询菜单
        public async static Task<List<DishEntity>> GetDishAsync()
        {
            return await context.Dishes.ToListAsync();
        }

        public static List<DishEntity> GetDishs()
        {
            return context.Dishes.ToList();
        }
    }
}
