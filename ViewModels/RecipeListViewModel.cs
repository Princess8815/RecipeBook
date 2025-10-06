using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RecipeBook.Models;
using RecipeBook.Models.Recipes;
using System.Collections.ObjectModel;

namespace RecipeBook.ViewModels
{
    public partial class RecipeListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string resultMessage = "detecting action";
        public static RecipeListViewModel Instance { get; } = new RecipeListViewModel();

        /// <summary>
        /// recipie collection
        /// </summary>
        public ObservableCollection<Recipe> Recipes { get; set; }

        public ObservableCollection<Recipe> Favorites { get; set; } = new();

        /// <summary>
        /// recipie chosen by used
        /// </summary>
        [ObservableProperty]
        private Recipe? selectedRecipe;

        /// <summary>
        /// initialize list viewModel
        /// </summary>
        private RecipeListViewModel()
        {


            Recipes = new ObservableCollection<Recipe>
            {
                ChickenStirFry.Create(),
                SpaghettiBolognese.Create()
            };
        }
        [RelayCommand]
        private void RecipeMenu(Recipe recipe)
        {
            // Notify whoever is listening (the Page) 
            RecipeSelected?.Invoke(recipe);
        }

        [RelayCommand]
        private void AddToFavorites(Recipe recipe)
        {
            if (!Favorites.Contains(recipe))
            {
                Favorites.Add(recipe);
                ResultMessage = $"{recipe.Title} added to favorites!";
            }
            else
            {
                ResultMessage = $"{recipe.Title} is already in favorites.";
            }
        }

        // Called when swiped left
        [RelayCommand]
        private void RemoveFromFavorites(Recipe recipe)
        {
            if (Favorites.Contains(recipe))
            {
                Favorites.Remove(recipe);
                ResultMessage = $"{recipe.Title} removed from favorites.";
            }
            else
            {
                ResultMessage = $"{recipe.Title} was not in favorites.";
            }
        }


        public event Action<Recipe>? RecipeSelected;
    }
}
