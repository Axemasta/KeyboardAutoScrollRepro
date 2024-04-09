using KeyboardAutoScrollRepro.Pages;
namespace KeyboardAutoScrollRepro;

public partial class App : Application
{
    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        var mainPage = serviceProvider.GetRequiredService<MainPage>();

        MainPage = new NavigationPage(mainPage);
    }
}