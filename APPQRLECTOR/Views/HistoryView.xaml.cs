using APPQRLECTOR.Services;
namespace APPQRLECTOR.Views;

public partial class HistoryView : ContentPage
{
	public HistoryView()
	{
		InitializeComponent();
	}

    private void OnClearClicked(object sender, EventArgs e)
    {
        HistoryService.Records.Clear();

        historyCollection.ItemsSource = null;
        historyCollection.ItemsSource = HistoryService.Records;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        historyCollection.ItemsSource = null;
        historyCollection.ItemsSource = HistoryService.Records;
    }
}