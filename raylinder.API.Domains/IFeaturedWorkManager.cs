using raylinder.Models;

namespace raylinder.API.Domains;

public interface IFeaturedWorkManager
{
    Task<IEnumerable<WorkProject>> GetWorkProjects();
}