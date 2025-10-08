using RecipeBook.Models.Recipes;
using System.Collections.Generic;

namespace RecipeBook.Models
{
    public class Recipe
    {
        public string? Title { get; set; }
        public string? ImageUrl { get; set; }
        public string? CookingTime { get; set; }
        public RecipeDetails? Details { get; set; }

        /// <summary>
        /// Returns all available recipes created by their respective classes.
        /// </summary>
        public static List<Recipe> GetAllRecipes()
        {
            return new List<Recipe>
            {
                ChickenStirFry.Create(),
                SpaghettiBolognese.Create(),
                // Add future recipes here, like:
                // PancakeStack.Create(),
                // VeggieCurry.Create(),
            };
        }
    }
}

