namespace APPQRLECTOR.Views;
using APPQRLECTOR.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string pass = txtPass.Text;

        if (user == "admin" && pass == "1234")
        {
            await Navigation.PushAsync(new HomeView());
        }
        else
        {
            lblError.Text = "Credenciales incorrectas";
            lblError.IsVisible = true;
        }
    }
}