using Blazored.LocalStorage;
using raylinder.App.Services;

namespace raylinder.App.Mobile;

public interface IBaseDomain
{
    IExperienceService ExperienceService { get; set; }
    IFeaturedWorkService FeaturedWorkService { get; set; }
    ILocalStorageService LocalStorageService { get; }
}
