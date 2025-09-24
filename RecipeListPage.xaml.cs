using RecipeBook.Models;
using RecipeBook.ViewModels;

namespace RecipeBook;

public partial class RecipeListPage : ContentPage
{
    private readonly RecipeListViewModel _vm;

    public RecipeListPage()
    {
        InitializeComponent();
        // this assigns the view model new RecipeListViewModel to the view
        _vm = new RecipeListViewModel();
        BindingContext = _vm;

        //a delegate for view model to call the OnRecipeSelected function
        _vm.RecipeSelected += OnRecipeSelected;
    }

    /// <summary>
    /// this function will open up the recipe details passin it its recipe to the window
    /// </summary>
    /// <param name="recipe"></param>
    private async void OnRecipeSelected(Recipe recipe)
    {
        // Create the details page
        var detailsPage = new RecipeBook.View.RecipeDetails
        {
            // Pass the whole Recipe object as BindingContext
            BindingContext = recipe
        };

        // Navigate to it
        await Navigation.PushAsync(detailsPage);
    }

}

