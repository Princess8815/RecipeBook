using System.Windows.Input;

namespace RecipeBook;

public partial class AppShell : Shell
{
    public ICommand GoHomeCommand { get; }
    public ICommand GoFavoritesCommand { get; }

    public AppShell()
    {
        InitializeComponent();

        // Commands wired up to Shell navigation
        GoHomeCommand = new Command(async () => await Shell.Current.GoToAsync("//home"));
        GoFavoritesCommand = new Command(async () => await Shell.Current.GoToAsync("//favorites"));

        BindingContext = this; // make the commands visible to XAML
    }
}

