namespace MauiApp10;

public partial class MainPage : ContentPage
{
    MainPageViewModel vm => (MainPageViewModel)BindingContext;
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }
}

