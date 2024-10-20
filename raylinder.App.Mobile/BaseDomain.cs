using Blazored.LocalStorage;
using raylinder.App.Services;

namespace raylinder.App.Mobile;

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
