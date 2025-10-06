using System;
using CommunityToolkit.Mvvm.ComponentModel;
using RecipeBook.Models;
using System.Collections.ObjectModel;

namespace RecipeBook.ViewModels
{
    public partial class FavoriteRecipesViewModel : ObservableObject
    {
        public ObservableCollection<Recipe> Favorites { get; set; }

        public FavoriteRecipesViewModel()
        {
            Favorites = RecipeListViewModel.Instance.Favorites;
        }
    }
}
