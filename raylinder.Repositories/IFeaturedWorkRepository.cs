
namespace raylinder.Repositories;

public interface IFeaturedWorkRepository<T>
{
    public Task<IEnumerable<T>> All();

    public Task<T> GetByTitle(string title);
}