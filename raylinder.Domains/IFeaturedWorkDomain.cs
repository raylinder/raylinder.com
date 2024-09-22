using raylinder.Entities;

namespace raylinder.Domains;

public interface IFeaturedWorkDomain
{
    Task<IEnumerable<WorkProject>> GetProjects();
}