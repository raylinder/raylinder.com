using raylinder.Entities;

namespace raylinder.App.Web.Services;

public interface IFeaturedWorkService
{
    Task<IEnumerable<WorkProject>> Get();
}