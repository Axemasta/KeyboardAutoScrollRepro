using The49.Maui.BottomSheet;
namespace KeyboardAutoScrollRepro.Pages;

public partial class ModalPage : ContentPage
{
    public ModalPage()
    {
        InitializeComponent();
    }

    private async void OnClicked(object? sender, EventArgs e)
    {
        if (sender is null)
        {
            return;
        }

        var bottomSheet = GetBottomSheet(sender);

        await bottomSheet.ShowAsync();
    }

    private BottomSheet GetBottomSheet(object sender)
    {
        if (sender == EditorButton)
        {
            return new EditorBottomSheet();
        }
        
        if (sender == EntryButton)
        {
            return new EntryBottomSheet();
        }

        throw new NotImplementedException($"Bottom sheet not implemented for sender: {sender.GetType().Name}");
    }
}