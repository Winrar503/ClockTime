﻿using ClockTime_MauiBlazor.Data;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ClockTime_MauiBlazor.Services;

namespace ClockTime_MauiBlazor
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
                });

            builder.Services.AddMauiBlazorWebView();

#if DEBUG
    		builder.Services.AddBlazorWebViewDeveloperTools();
    		builder.Logging.AddDebug();
#endif
            builder.Services.AddDbContext<AppDbContext>(options =>
                    options.UseSqlServer(@"Data Source=DESKTOP-G786A4S\SQLEXPRESS;
                                      Initial Catalog=bloc;
                                      Integrated Security=True;
                                      Encrypt=False;
                                      TrustServerCertificate=True"));


            return builder.Build();
        }
    }
}
