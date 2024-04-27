using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiShellNavigationTest.Pages;
using MauiShellNavigationTest.ViewModel;

namespace MauiShellNavigationTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();

            //RegisterViewsAndViewModels<AppointmentsMainPage, MainPageVM>("");
        }


        
    }
}
