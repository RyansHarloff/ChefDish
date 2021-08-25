using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace ChefDish.Models{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        [Required]
        public string DishName {get;set;}
        [Required]
        public int Calories {get;set;}
        [Required]
        public string Description{get;set;}
        [Required]
        [Range(1,5)]
        public int Tastiness {get;set;}
        public DateTime CreatedAt {get;set;}
        public DateTime UpdatedAt {get;set;}
        public int ChefId {get;set;}
        public Chef Chef {get;set;}
    }
}