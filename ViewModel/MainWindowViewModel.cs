using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using Restaurant.Data;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Restaurant.ViewModel
{
    public class MainWindowViewModel:NotificationObject
    {
        public DelegateCommand PlaceOrderCommand { get; set; }
        public DelegateCommand SelectMenuItemCommand { get; set;}

        private int count;

        public int Count
        {
            get { return count; }
            set 
            { 
                count = value; 
                this.RaisePropertyChanged("Count"); 
            }
        }

        private RestaurantEntity restaurant;
        public RestaurantEntity Restaurant
        {
            get { return restaurant; }
            set
            {
                restaurant = value;
                this.RaisePropertyChanged("Restaurant");
            }
        }

        private List<DishMenuItemViewModel> dishMenu;

        public List<DishMenuItemViewModel> DishMenu
        {
            get { return dishMenu; }
            set { dishMenu = value; this.RaisePropertyChanged("DishMenu"); }
        }

        public MainWindowViewModel()
        {
            this.LoadRestaurant();
            this.LoadDish();
            this.PlaceOrderCommand = new DelegateCommand(new Action(this.PlaceOrderCommandExecute));
            this.SelectMenuItemCommand = new DelegateCommand(new Action(this.SelectMenuItemCommanExecute));
        }

        public void LoadRestaurant()
        {
            var queryEntity = EntityDal.GetRestaurants().FirstOrDefault();
            this.Restaurant = new RestaurantEntity();
            this.Restaurant.Name = queryEntity?.Name;
            this.Restaurant.Address = queryEntity?.Address;
            this.Restaurant.Phone = queryEntity?.Phone;
        }

        public void LoadDish()
        {
            var queryList = EntityDal.GetDishs();

            this.DishMenu = new List<DishMenuItemViewModel>();
            foreach (var item in queryList) 
            { 
                DishMenuItemViewModel dish = new DishMenuItemViewModel();
                dish.Dish = item;
                this.DishMenu.Add(dish);
            }
        }

        private void PlaceOrderCommandExecute()
        {
            var selectedDishes = this.DishMenu.Where(p=>p.IsSelected == true).Select(p => p.Dish.Name).ToList();
            MessageBox.Show($"订餐成功；餐品为：{string.Join(",", selectedDishes)}");
        }
        private void SelectMenuItemCommanExecute()
        {
            this.Count = this.DishMenu.Count(p => p.IsSelected == true);
        }
    }
}
