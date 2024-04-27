using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui.Markup;
using CommunityToolkit.Maui;
using MauiShellNavigationTest.Pages;
using MauiShellNavigationTest.ViewModel;

namespace MauiShellNavigationTest
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiCommunityToolkitMarkup()
                   .UseMauiApp<App>()
                   .UseMauiCommunityToolkit()
                   .ConfigureFonts(fonts =>
                  {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                 });

#if DEBUG
            builder.Logging.AddDebug();
#endif

            RegisterViewsAndViewModels<AppointmentsMainPage, AppointmentMainPageVM>(builder.Services, nameof(AppointmentMainPageVM));
            RegisterViewsAndViewModels<AppointmentsListPage, AppointmentsListVM>(builder.Services, nameof(AppointmentsListVM));

            return builder.Build();
        }


        public static void RegisterViewsAndViewModels<TPage, TViewModel>(in IServiceCollection services, string route)
        where TPage : BasePage<TViewModel>
        where TViewModel : BaseViewModel
        {
            services.AddTransientWithShellRoute<TPage, TViewModel>(route);

        }
    }
}
