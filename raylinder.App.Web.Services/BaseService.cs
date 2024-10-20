using System.Text.Json;
using Microsoft.AspNetCore.Components;

namespace raylinder.App.Services;

public class BaseService : IBaseService
{
    public BaseService(IHttpClientFactory httpClientFactory, NavigationManager navigationManager)
    {
        NavigationManager = navigationManager;
        HttpClient = httpClientFactory.CreateClient("WebAPI.Anonymous");
        JsonSerializerOptions = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
    }

    public NavigationManager NavigationManager { get; set; }

    public HttpClient HttpClient { get; }

    public JsonSerializerOptions JsonSerializerOptions { get; set; }
}
