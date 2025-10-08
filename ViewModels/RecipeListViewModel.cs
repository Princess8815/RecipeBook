using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RecipeBook.Models;
using System.Collections.ObjectModel;

namespace RecipeBook.ViewModels
{
    public partial class RecipeListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? resultMessage = "detecting action";

        public static RecipeListViewModel Instance { get; } = new();

        public ObservableCollection<Recipe> Recipes { get; set; }
        public ObservableCollection<Recipe> Favorites { get; set; } = new();

        [ObservableProperty]
        private Recipe? selectedRecipe;

        private RecipeListViewModel()
        {
            // 🧠 Pull from Recipe model
            Recipes = new ObservableCollection<Recipe>(Recipe.GetAllRecipes());
        }

        [RelayCommand]
        private void RecipeMenu(Recipe recipe)
        {
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

