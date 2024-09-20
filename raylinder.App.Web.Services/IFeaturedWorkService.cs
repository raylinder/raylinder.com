using raylinder.Models;

namespace raylinder.App.Web.Services;

public interface IFeaturedWorkService
{
    Task<IEnumerable<WorkProject>> Get();
}