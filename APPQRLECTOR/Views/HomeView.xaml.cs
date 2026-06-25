namespace APPQRLECTOR.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
	}

    private async void OnScanClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ScanView());
    }

    private async void OnHistoryClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HistoryView());
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}