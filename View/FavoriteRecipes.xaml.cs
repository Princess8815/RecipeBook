using RecipeBook.ViewModels;

namespace RecipeBook.View
{
    public partial class FavoriteRecipes : ContentPage
    {
        public FavoriteRecipes()
        {
            InitializeComponent();
            BindingContext = new FavoriteRecipesViewModel();
        }
    }
}


