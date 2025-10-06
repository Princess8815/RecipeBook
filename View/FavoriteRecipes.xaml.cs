using RecipeBook.ViewModels;

namespace RecipeBook.View;

public partial class FavoriteRecipes : ContentPage
{
    public FavoriteRecipes()
    {
        InitializeComponent();

        // Force it to use the exact same instance that the recipe list uses
        BindingContext = RecipeListViewModel.Instance;
    }
}
