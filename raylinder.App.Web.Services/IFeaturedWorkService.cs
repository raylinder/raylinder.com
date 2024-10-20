using raylinder.Entities;

namespace raylinder.App.Services;

public interface IFeaturedWorkService
{
    Task<IEnumerable<WorkProject>> Get();
}