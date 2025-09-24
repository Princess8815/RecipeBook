using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using RecipeBook.Models;
using RecipeBook.Models.Recipes;
using System.Collections.ObjectModel;

namespace RecipeBook.ViewModels
{
    public partial class RecipeListViewModel : ObservableObject
    {
        public ObservableCollection<Recipe> Recipes { get; set; }

        [ObservableProperty]
        private Recipe? selectedRecipe;

        public RecipeListViewModel()
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

        public event Action<Recipe>? RecipeSelected;
    }
}
