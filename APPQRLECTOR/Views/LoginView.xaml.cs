namespace APPQRLECTOR.Views;

public partial class LoginView : ContentPage
{
	public LoginView()
	{
		InitializeComponent();
	}

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string user = txtUser.Text;
        string pass = txtPass.Text;

        if (user == "admin" && pass == "1234")
        {
            Application.Current.MainPage = new AppShell();
        }
        else
        {
            lblError.Text = "Credenciales incorrectas";
            lblError.IsVisible = true;
        }
    }
}