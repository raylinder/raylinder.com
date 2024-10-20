using Blazored.LocalStorage;
using Microsoft.Extensions.Logging;
using MudBlazor.Services;
using raylinder.App.Services;
using System.Net.Http.Headers;

namespace raylinder.App.Mobile;
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

        var hostEnvironment = "Production";

#if DEBUG
        hostEnvironment = "Development";
#endif

        var environmentApiUrl = "";
        var logLevel = LogLevel.Information;

        switch (hostEnvironment)
        {
            case "Development":
                environmentApiUrl = "http://raylinder-api.azurewebsites.net";
                logLevel = LogLevel.Trace;
                break;
            case "Production":
                environmentApiUrl = "http://raylinder-api.azurewebsites.net";
                logLevel = LogLevel.Error;
                break;
        }

        builder.Services.AddOptions();

        builder.Services.AddHttpClient("WebAPI.Anonymous", client =>
        {
            client.BaseAddress = new Uri(environmentApiUrl);

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Origin", "*");
            //client.DefaultRequestHeaders.Add("Access-Control-Allow-Credentials", "true");
            client.DefaultRequestHeaders.Add("Access-Control-Allow-Headers", "Access-Control-Allow-Origin,Content-Type");
        });

        builder.Services.AddBlazoredLocalStorage();

        builder.Services.AddScoped<IBaseDomain, BaseDomain>();
        builder.Services.AddScoped<IBaseService, BaseService>();
        builder.Services.AddScoped<IExperienceService, ExperienceService>();
        builder.Services.AddScoped<IFeaturedWorkService, FeaturedWorkService>();

        builder.Services.AddMudServices();
        builder.Services.AddMauiBlazorWebView();

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
