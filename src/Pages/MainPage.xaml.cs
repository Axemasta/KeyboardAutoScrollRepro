namespace KeyboardAutoScrollRepro.Pages;

public partial class MainPage : ContentPage
{
    private readonly IServiceProvider _serviceProvider;
    
    public MainPage(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
        
        InitializeComponent();
    }

    private void OnClicked(object? sender, EventArgs e)
    {
        var modalPage = _serviceProvider.GetRequiredService<ModalPage>();

        Navigation.PushModalAsync(new NavigationPage(modalPage));
    }
}