namespace raylinder.API.Domains;

public interface IExperienceManager
{
    Task<double[]> GetTotals();
}