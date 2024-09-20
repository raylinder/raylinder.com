using Blazored.LocalStorage;
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
        environmentApiUrl = "http://localhost:5109";
        logLevel = LogLevel.Trace;
        break;
    case "Production":
        environmentApiUrl = "http://raylinder-api.azurewebsites.net";
        logLevel = LogLevel.Error;
        break;
}

builder.Services.AddOptions();
//builder.Services.AddScoped<IAccessTokenProvider, AccessTokenProvider>();
//builder.Services.AddScoped<AuthorizationMessageHandler>();
//builder.Services.AddApiAuthorization();

//builder.Services.AddHttpClient("WebAPI", (sp, cl) =>
//{
//    cl.BaseAddress = new Uri(environmentApiUrl);

//    //cl.DefaultRequestHeaders.Add("Accept", "application/json");
//    cl.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
//});

////.AddHttpMessageHandler(sp => sp.GetRequiredService<AuthorizationMessageHandler>().ConfigureHandler(new[] { environmentApiUrl }, new[] { "api" }));

//builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebAPI"));

builder.Services.AddHttpClient("WebAPI.Anonymous", client =>
{
    client.BaseAddress = new Uri(environmentApiUrl);

    //client.DefaultRequestHeaders.Add("Accept", "application/json");
    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
});

builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("WebAPI.Anonymous"));

builder.Services.AddBlazoredLocalStorage();
//builder.Services.AddBlazoredModal();
//builder.Services.AddBlazoredToast();

//builder.Services.AddAuthorizationCore();
//builder.Services.AddScoped<IAuthenticationService, AuthenticationService>();
//builder.Services.AddScoped<ApiAuthenticationStateProvider>();
//builder.Services.AddScoped<AuthenticationStateProvider>(provider => provider.GetRequiredService<ApiAuthenticationStateProvider>());

builder.Services.AddScoped<IBaseDomain, BaseDomain>();
builder.Services.AddScoped<IBaseService, BaseService>();
builder.Services.AddScoped<IFeaturedWorkService, FeaturedWorkService>();
//builder.Services.AddScoped<IPinService, PinService>();
//builder.Services.AddScoped<IEventService, EventService>();
//builder.Services.AddScoped<IContactService, ContactService>();
//builder.Services.AddScoped<ICompanyService, CompanyService>();
//builder.Services.AddScoped<IFeedbackService, FeedbackService>();

builder.Services.AddLogging(logging => logging.SetMinimumLevel(logLevel));












//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();

await builder.Build().RunAsync();
