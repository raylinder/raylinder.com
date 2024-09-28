
using raylinder.Entities;

namespace raylinder.Repositories;

public interface IExperienceRepository<T> where T : class, new()
{
    public Task<IEnumerable<T>> GetExperiences();
    public Task<IEnumerable<WorkExperienceDescription>> GetExperienceDescriptions();
    Task<IEnumerable<Skill>> GetSkills();
}