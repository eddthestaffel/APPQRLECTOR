namespace APPQRLECTOR.Views;

using APPQRLECTOR.Models;
using APPQRLECTOR.Services;
using System.Linq;

public partial class ScanView : ContentPage
{
    public ScanView()
    {
        InitializeComponent();
    }

    private void CameraView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        var result = e.Results.FirstOrDefault();

        if (result == null)
            return;

        MainThread.BeginInvokeOnMainThread(() =>
        {
            lblResult.Text = result.Value;

            var last = HistoryService.Records.LastOrDefault();

            if (last?.Content != result.Value)
            {
                HistoryService.Records.Add(new ScanRecord
                {
                    Content = result.Value,
                    ScanDate = DateTime.Now
                });
            }
        });
    }
}