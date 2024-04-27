using MauiShellNavigationTest.ViewModel;

namespace MauiShellNavigationTest.Pages;

public partial class AppointmentsMainPage : BasePage<AppointmentMainPageVM>
{
    public AppointmentsMainPage(AppointmentMainPageVM pDataContext):base(pDataContext)
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        var txt = sender as Microsoft.Maui.Controls.Button;
        if (txt != null)
        {
            if (txt.Text == "Today")
            {
                var navigationParameters = new Dictionary<string, object> {
                    { "ListType", "Today" }
                };
                
                await Shell.Current.GoToAsync(nameof(AppointmentsListVM), navigationParameters);
            }
            else if (txt.Text == "Other")
            {
                var navigationParameters = new Dictionary<string, object> {
                    { "ListType", "Other" }
                };

                await Shell.Current.GoToAsync(nameof(AppointmentsListVM), navigationParameters);
            }
        }
    }
}