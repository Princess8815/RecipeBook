using System.Collections.Generic;

namespace RecipeBook.Models.Recipes
{
    public static class SpaghettiBolognese
    {
        public static Recipe Create()
        {
            return new Recipe
            {
                Title = "Spaghetti Bolognese",
                ImageUrl = "spaghetti.jpg", // replace with real image if available
                CookingTime = "45 minutes",
                Details = new RecipeDetails
                {
                    Description = "A hearty Italian classic with a rich tomato and meat sauce served over pasta.",

                    Ingredients = new List<string>
                    {
                        "12 oz spaghetti",
                        "1 lb ground beef (or mix of beef & pork)",
                        "2 tbsp olive oil",
                        "1 medium onion, finely chopped",
                        "2 cloves garlic, minced",
                        "1 carrot, finely diced",
                        "1 celery stalk, finely diced",
                        "1 can (28 oz) crushed tomatoes",
                        "2 tbsp tomato paste",
                        "1/2 cup beef broth (or red wine for richness)",
                        "1 tsp dried oregano",
                        "1 tsp dried basil",
                        "1/2 tsp salt",
                        "1/4 tsp black pepper",
                        "Parmesan cheese (for serving)",
                        // optional
                        "Optional: fresh parsley, chopped (for garnish)"
                    },

                    Instructions =
@"1. Cook spaghetti in salted boiling water according to package directions. Drain and set aside. 
2. Heat olive oil in a large skillet over medium heat. Add onion, garlic, carrot, and celery. Cook 5–7 minutes until softened. 
3. Add ground beef. Cook until browned, breaking it apart with a spoon. 
4. Stir in tomato paste and cook for 1 minute. 
5. Add crushed tomatoes, beef broth (or wine), oregano, basil, salt, and pepper. Stir well. 
6. Reduce heat and simmer uncovered for 20–25 minutes, stirring occasionally, until sauce thickens. 
7. Taste and adjust seasoning if needed. 
8. Serve sauce over cooked spaghetti. Top with Parmesan and parsley if desired."
                }
            };
        }
    }
}

