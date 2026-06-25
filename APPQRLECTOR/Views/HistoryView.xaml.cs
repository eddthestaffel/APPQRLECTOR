namespace APPQRLECTOR.Views;

using APPQRLECTOR.Services;
using Microsoft.Maui.ApplicationModel;
using APPQRLECTOR.Models;

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

    private async void OnLinkTapped(object sender, TappedEventArgs e)
    {
        if (sender is Label label &&
            label.BindingContext is APPQRLECTOR.Models.ScanRecord record)
        {
            if (Uri.TryCreate(record.Content, UriKind.Absolute, out var uri))
            {
                await Launcher.Default.OpenAsync(uri);
            }
        }
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        historyCollection.ItemsSource = null;
        historyCollection.ItemsSource = HistoryService.Records;
    }
}