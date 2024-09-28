using Blazored.LocalStorage;
using raylinder.App.Web.Services;

namespace RayLinder;

public class BaseDomain : IBaseDomain
{
    public BaseDomain(IExperienceService experienceService, IFeaturedWorkService featuredWorkService, ILocalStorageService localStorageService)
    {
        ExperienceService = experienceService;
        FeaturedWorkService = featuredWorkService;
        LocalStorageService = localStorageService;
    }

    public IExperienceService ExperienceService { get; set; }
    public IFeaturedWorkService FeaturedWorkService { get; set; }
    public ILocalStorageService LocalStorageService { get; }
}
