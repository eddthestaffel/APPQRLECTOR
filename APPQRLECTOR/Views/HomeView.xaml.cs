namespace APPQRLECTOR.Views;

public partial class HomeView : ContentPage
{
	public HomeView()
	{
		InitializeComponent();
	}

	private void OnScanClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new AppShell();
        Shell.Current.GoToAsync("//ScanView");
    }
    private void OnHistoryClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//HistoryView");
    }

    private void OnLogoutClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new LoginView());
    }
}