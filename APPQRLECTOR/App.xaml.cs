using APPQRLECTOR.Views;
using Microsoft.Extensions.DependencyInjection;

namespace APPQRLECTOR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var navPage = new NavigationPage(new LoginView())
            {
                BarBackground = Color.FromArgb("#0F172A"),
                BackgroundColor = Color.FromArgb("#0F172A")
            };
            return new Window(new NavigationPage(new LoginView()));
        }
    }
}