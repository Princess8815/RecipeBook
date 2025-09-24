using System.Collections.Generic;

namespace RecipeBook.Models.Recipes
{
    public static class ChickenStirFry
    {
        public static Recipe Create()
        {
            return new Recipe
            {
                Title = "Chicken Stir Fry",
                ImageUrl = "chicken_stirfry.jpg",
                CookingTime = "25 minutes",
                Details = new RecipeDetails
                {
                    Description = "A flavorful and quick stir fry with tender chicken, crisp vegetables, and a savory sauce.",

                    Ingredients = new List<string>
                    {
                        "1 lb boneless, skinless chicken breast (sliced thin)",
                        "2 tbsp vegetable oil",
                        "1 cup broccoli florets",
                        "1 red bell pepper, sliced",
                        "1 carrot, thinly sliced",
                        "3 green onions, chopped",
                        "2 cloves garlic, minced",
                        "1 tbsp fresh ginger, grated",
                        "3 tbsp soy sauce",
                        "1 tbsp Worcestershire sauce",
                        "1 tbsp oyster sauce (optional, for depth)",
                        "1 tsp sesame oil",
                        "1 tsp cornstarch mixed with 2 tbsp water (slurry)",
                        "Cooked rice or noodles (for serving)",
                        // optional extras
                        "Optional: 1 jalapeño, thinly sliced (for heat)",
                        "Optional: sesame seeds (for garnish)"
                    },

                    Instructions =
@"1. Slice chicken breast thinly into bite-sized strips. 
2. Heat 1 tbsp vegetable oil in a wok or large skillet over medium-high heat. 
3. Add chicken and stir fry for 4–5 minutes until golden and cooked through. Remove chicken and set aside. 
4. Add remaining oil to the wok. Stir fry garlic and ginger for 30 seconds until fragrant. 
5. Add broccoli, bell pepper, carrot, and green onion (and jalapeño if using). Cook for 3–4 minutes until vegetables are tender-crisp. 
6. Return chicken to the wok. Stir in soy sauce, Worcestershire sauce, oyster sauce (if using), and sesame oil. 
7. Pour in cornstarch slurry and stir until sauce thickens and coats everything evenly (about 1 minute). 
8. Remove from heat. Garnish with sesame seeds if desired. 
9. Serve hot over steamed rice or noodles."
                }
            };
        }
    }
}


