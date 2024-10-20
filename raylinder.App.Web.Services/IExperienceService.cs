using raylinder.Entities;

namespace raylinder.App.Services;

public interface IExperienceService
{
    Task<IEnumerable<WorkExperience>> Get();


    Task<IEnumerable<Skill>> GetSkills();
}
