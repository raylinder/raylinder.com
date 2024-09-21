using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace raylinder.App.Web.Services;

public class BaseService : IBaseService
{
    public BaseService(IHttpClientFactory httpClientFactory, HttpClient httpClient, NavigationManager navigationManager)
    {
        NavigationManager = navigationManager;
        HttpClientFactory = httpClientFactory;
        HttpClient = httpClientFactory.CreateClient("WebAPI.Anonymous");
        JsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public NavigationManager NavigationManager { get; set; }

    public IHttpClientFactory HttpClientFactory { get; set; }

    public HttpClient HttpClient { get; }

    public JsonSerializerOptions JsonSerializerOptions { get; set; }
}
