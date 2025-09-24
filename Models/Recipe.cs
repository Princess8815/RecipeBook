using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public string? Title { get; set; }
        //public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public List<string>? Ingredients { get; set; }
        //public string? Instructions { get; set; }
        public string? CookingTime { get; set; }

        public RecipeDetails? Details { get; set; }
    }
}
