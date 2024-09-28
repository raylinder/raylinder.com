using raylinder.Entities;

namespace raylinder.Repositories;

public class FeaturedWorkRepository<T> : IFeaturedWorkRepository<T> where T : WorkProject, new()
{
    private IEnumerable<T> _entities;

    public FeaturedWorkRepository()
    {
        _entities = (IEnumerable<T>?)new Data.FeaturedWorkData().WorkProjects;
    }

    public Task<T> GetByTitle(string title) => Task.FromResult(_entities.FirstOrDefault(e => e.Title == title));

    public Task<IEnumerable<T>> All() => Task.FromResult(_entities);
}
