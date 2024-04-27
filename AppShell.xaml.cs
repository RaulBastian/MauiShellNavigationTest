using MauiShellNavigationTest.Pages;

namespace MauiShellNavigationTest
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            this.BindingContext = this;
            this.registerRoutes();
        }

        public bool IsLoggedIn
        {
            get => (bool)GetValue(IsLoggedInProperty);
            set => SetValue(IsLoggedInProperty, value);
        }

        public static readonly BindableProperty IsLoggedInProperty =
            BindableProperty.Create(nameof(IsLoggedIn), typeof(bool), typeof(AppShell), false, propertyChanged: IsLogged_PropertyChanged);


        private static void IsLogged_PropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            //handle log in/log out event
            if ((bool)newValue)
            {

            }
            //user just logged in logic
            else
            {

            }
            //user just logged out logic
        }


        private void registerRoutes()
        {
            //Routing.RegisterRoute("List", typeof(AppointmentsListPage));
        }
    }
}
