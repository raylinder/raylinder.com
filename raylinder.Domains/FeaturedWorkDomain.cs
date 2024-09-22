using raylinder.Entities;
using raylinder.Repositories;

namespace raylinder.Domains;

public class FeaturedWorkDomain : IFeaturedWorkDomain
{
    private IFeaturedWorkRepository<WorkProject> _featuredWorkRepository;

    public FeaturedWorkDomain(IFeaturedWorkRepository<WorkProject> featuredWorkRepository)
    {
        _featuredWorkRepository = featuredWorkRepository;
    }

    public async Task<IEnumerable<WorkProject>> GetProjects()
    {
        return await _featuredWorkRepository.All();
    }
}
