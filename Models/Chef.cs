using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ChefDish.Models
{
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}
        [Required]
        public string FirstName {get;set;}
        [Required]
        public string LastName {get;set;}
        [Required]
        public int DateOfBirth {get;set;}
        public DateTime CreatedAt {get;set;}=DateTime.Now;
        public DateTime UpdatedAt {get;set;}=DateTime.Now;
        public List<Dish> AllDishes {get;set;}
    }
}