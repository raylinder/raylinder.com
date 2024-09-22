using raylinder.Entities;

namespace raylinder.Repositories;

public class FeaturedWorkRepository<T> : IFeaturedWorkRepository<T> where T : WorkProject, new()
{
    private IBaseRepository _baseRepository { get; }
    private IEnumerable<T> entities;

    public FeaturedWorkRepository(IBaseRepository baseRepository)
    {
        _baseRepository = baseRepository;

        entities = new Data.FeaturedWorkData<T>().WorkProjects;
    }

    public Task<T> GetByTitle(string title) => Task.FromResult(entities.FirstOrDefault(e => e.Title == title));

    public Task<IEnumerable<T>> All() => Task.FromResult(entities);
}
