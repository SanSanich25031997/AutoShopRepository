using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities.Cars;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Entities.AutoShopCartItems
{
    [Table("autoShopCartItems")]
    public class AutoShopCartItem
    {
        [Key]
        public string Id { get; set; }
        public Car Car { get; set; }
        public int Price { get; set; }
        public string AutoShopCartId { get; set; }
    }
}
