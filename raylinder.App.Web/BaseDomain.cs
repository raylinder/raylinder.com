using Blazored.LocalStorage;
using raylinder.App.Web.Services;

namespace RayLinder;

public class BaseDomain : IBaseDomain
{
    //public BaseDomain(IFeaturedWorkService featuredWorkService, IAuthenticationService authenticationService, ILocalStorageService localStorageService)
    public BaseDomain(IFeaturedWorkService featuredWorkService, ILocalStorageService localStorageService)
    {
        FeaturedWorkService = featuredWorkService;
        //AuthenticationService = authenticationService;
        LocalStorageService = localStorageService;
    }

    public IFeaturedWorkService FeaturedWorkService { get; set; }

    //public IAuthenticationService AuthenticationService { get; set; }

    public ILocalStorageService LocalStorageService { get; }
}