using HappyDart.Ui.Features.LogIn;
using HappyDart.Ui.Features.Main;
using Microsoft.Extensions.Logging;

namespace HappyDart.Ui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddTransient<LogInViewModel>();
            builder.Services.AddTransient(sp =>
            {
                var logInView = new LogInView();
                logInView.BindingContext = sp.GetRequiredService<LogInViewModel>();
                return logInView;
            });

            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient(sp =>
            {
                var logInView = new MainView();
                logInView.BindingContext = sp.GetRequiredService<MainViewModel>();
                return logInView;
            });

            return builder.Build();
        }
    }
}
