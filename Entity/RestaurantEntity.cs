﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.Entity
{
    [Table("Restaurant")]
    public class RestaurantEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Address { get; set; }
        public string Phone { get; set; }

    }
}
