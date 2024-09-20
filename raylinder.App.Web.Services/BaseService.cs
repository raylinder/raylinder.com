using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace raylinder.App.Web.Services;

public class BaseService : IBaseService
{
    //public BaseService(IHttpClientFactory httpClientFactory, ILocalStorageService localStorageService, HttpClient httpClient, NavigationManager navigationManager)
    public BaseService(IHttpClientFactory httpClientFactory, HttpClient httpClient, NavigationManager navigationManager)
    {
        NavigationManager = navigationManager;
        HttpClientFactory = httpClientFactory;
        //LocalStorageService = localStorageService;
        HttpClient = httpClientFactory.CreateClient("WebAPI.Anonymous"); //httpClient ?? throw new ArgumentNullException(nameof(httpClient), "Http is null.");
        //AnonymousHttpClient = httpClientFactory.CreateClient("WebAPI.Anonymous");

        ////ApiAuthenticationStateProvider = apiAuthenticationStateProvider;
        JsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public NavigationManager NavigationManager { get; set; }

    public IHttpClientFactory HttpClientFactory { get; set; }

    //public ILocalStorageService LocalStorageService { get; }

    public HttpClient HttpClient { get; }

    //public HttpClient AnonymousHttpClient { get; }

    ////public ApiAuthenticationStateProvider ApiAuthenticationStateProvider { get; }

    public JsonSerializerOptions JsonSerializerOptions { get; set; }

}
