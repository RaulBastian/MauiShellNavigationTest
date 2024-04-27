namespace MauiShellNavigationTest.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var typedShell = (Shell.Current as AppShell);
        if (typedShell != null)
        {
            typedShell.IsLoggedIn = true;
        }

        await Shell.Current.GoToAsync("//AppointmentsListPage");
        
    }
}