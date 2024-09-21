﻿using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using raylinder.App.Web.Services;
using RayLinder;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
var hostEnvironment = builder.HostEnvironment;

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
var environmentApiUrl = "";
var logLevel = LogLevel.Information;

switch (hostEnvironment.Environment)
{
    case "Local":
    case "Development":
        //environmentApiUrl = "http://localhost:5109";
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

    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
});

//builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebAPI.Anonymous"));

builder.Services.AddBlazoredLocalStorage();

builder.Services.AddScoped<IBaseDomain, BaseDomain>();
builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<IFeaturedWorkService, FeaturedWorkService>();

builder.Services.AddLogging(logging => logging.SetMinimumLevel(logLevel));

builder.Services.AddMudServices();

await builder.Build().RunAsync();
