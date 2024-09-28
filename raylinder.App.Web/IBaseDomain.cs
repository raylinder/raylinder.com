using Blazored.LocalStorage;
using raylinder.App.Web.Services;

namespace RayLinder;

public interface IBaseDomain
{
    IExperienceService ExperienceService { get; set; }
    IFeaturedWorkService FeaturedWorkService { get; set; }
    ILocalStorageService LocalStorageService { get; }
}
