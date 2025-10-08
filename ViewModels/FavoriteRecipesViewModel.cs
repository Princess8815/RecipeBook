using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RecipeBook.Models;
using System.Collections.ObjectModel;

namespace RecipeBook.ViewModels
{
    public partial class FavoriteRecipesViewModel : ObservableObject
    {
        private readonly RecipeListViewModel _recipeListViewModel;

        [ObservableProperty]
        private ObservableCollection<Recipe> favorites;

        [ObservableProperty]
        private string resultMessage = "Viewing your favorites";

        public FavoriteRecipesViewModel()
        {
            _recipeListViewModel = RecipeListViewModel.Instance;
            Favorites = _recipeListViewModel.Favorites;
        }

        // ✅ Double tap opens details directly
        [RelayCommand]
        private async Task RecipeMenu(Recipe recipe)
        {
            if (recipe == null)
                return;

            // Open details page directly from Favorites
            var detailsPage = new View.RecipeDetails
            {
                BindingContext = recipe
            };

            await Shell.Current.Navigation.PushAsync(detailsPage);
        }

        // ✅ Swipe right: add
        [RelayCommand]
        private void AddToFavorites(Recipe recipe)
        {
            _recipeListViewModel.AddToFavoritesCommand.Execute(recipe);
            ResultMessage = $"{recipe.Title} added to favorites!";
        }

        // ✅ Swipe left: remove
        [RelayCommand]
        private void RemoveFromFavorites(Recipe recipe)
        {
            _recipeListViewModel.RemoveFromFavoritesCommand.Execute(recipe);
            ResultMessage = $"{recipe.Title} removed from favorites!";
        }
    }
}



