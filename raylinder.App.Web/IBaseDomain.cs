using Blazored.LocalStorage;
using raylinder.App.Web.Services;

namespace RayLinder;

public interface IBaseDomain
{
    IFeaturedWorkService FeaturedWorkService { get; set; }
    ILocalStorageService LocalStorageService { get; }
}