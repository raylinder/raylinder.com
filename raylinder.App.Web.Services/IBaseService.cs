using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace raylinder.App.Services;

public interface IBaseService
{
    public NavigationManager NavigationManager { get; }

    //public ILocalStorageService LocalStorageService { get; }

    public HttpClient HttpClient { get; }

    //public HttpClient AnonymousHttpClient { get; }

    ////public ApiAuthenticationStateProvider ApiAuthenticationStateProvider { get; }

    public JsonSerializerOptions JsonSerializerOptions { get; set; }
}