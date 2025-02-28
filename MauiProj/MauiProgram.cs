﻿using MasterPassPoc.Platforms.Android;
using MasterPassPoc.Service;
using Microsoft.Extensions.Logging;

namespace MasterPassPoc
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#if DEBUG
            builder.Logging.AddDebug();
#endif
#if ANDROID
            builder.Services.AddSingleton<IMasterPassService, MasterPassService>();
#endif
            

            // Register MainPage and AppShell
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddSingleton<AppShell>();

            return builder.Build();
        }
    }
}