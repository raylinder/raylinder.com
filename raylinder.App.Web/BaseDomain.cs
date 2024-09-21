using Blazored.LocalStorage;
using raylinder.App.Web.Services;

namespace RayLinder;

public class BaseDomain : IBaseDomain
{
    public BaseDomain(IFeaturedWorkService featuredWorkService, ILocalStorageService localStorageService)
    {
        FeaturedWorkService = featuredWorkService;
        LocalStorageService = localStorageService;
    }

    public IFeaturedWorkService FeaturedWorkService { get; set; }

    public ILocalStorageService LocalStorageService { get; }
}