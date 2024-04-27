
using MauiShellNavigationTest.ViewModel;

namespace MauiShellNavigationTest.Pages;

public partial class AppointmentsListPage : BasePage<AppointmentsListVM>, IQueryAttributable
{
    public AppointmentsListPage(AppointmentsListVM pDataContext) : base(pDataContext)
    {
        InitializeComponent();
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        
    }
}