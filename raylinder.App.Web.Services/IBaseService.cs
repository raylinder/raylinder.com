using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace raylinder.App.Web.Services;

public interface IBaseService
{
    public NavigationManager NavigationManager { get; }

    public IHttpClientFactory HttpClientFactory { get; set; }

    //public ILocalStorageService LocalStorageService { get; }

    public HttpClient HttpClient { get; }

    //public HttpClient AnonymousHttpClient { get; }

    ////public ApiAuthenticationStateProvider ApiAuthenticationStateProvider { get; }

    public JsonSerializerOptions JsonSerializerOptions { get; set; }
}