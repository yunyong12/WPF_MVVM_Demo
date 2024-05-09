﻿using Microsoft.Practices.Prism.ViewModel;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.ViewModel
{
    public class DishMenuItemViewModel : NotificationObject
    {
        public DishEntity Dish { get; set; }

		private bool isSelected;

		public bool IsSelected
		{
			get 
			{ 
				return isSelected;
			}
			set 
			{ 
				isSelected = value;
				this.RaisePropertyChanged("IsSelected");
			
			}
		}
    }
}
