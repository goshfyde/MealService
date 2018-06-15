using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MealService.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Directions { get; set; }
        public string Category { get; set; }
    }
}
