using RecipeBook.ViewModels;

namespace RecipeBook.View;

public partial class RecipeDetails : ContentPage
{
    private readonly RecipeDetailsViewModel _vm;
    /// <summary>
    /// loads recipies details 
    /// </summary>
    public RecipeDetails()
	{
		InitializeComponent();
        // this assigns the view model new RecipeDetailsViewModel to the view
        _vm = new RecipeDetailsViewModel();
        BindingContext = _vm;
    }
}