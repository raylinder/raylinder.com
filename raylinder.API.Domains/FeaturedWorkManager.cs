using raylinder.Domains;
using raylinder.Entities;

namespace raylinder.API.Domains;
public class FeaturedWorkManager : IFeaturedWorkManager
{
    private IFeaturedWorkDomain _featuredWorkDomain;

    public FeaturedWorkManager(IFeaturedWorkDomain featuredWorkDomain)
    {
        _featuredWorkDomain = featuredWorkDomain;
    }

    public async Task<IEnumerable<WorkProject>> GetWorkProjects()
    {
        return await _featuredWorkDomain.GetProjects();
    }
}
