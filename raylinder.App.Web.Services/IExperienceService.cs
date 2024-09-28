using raylinder.Entities;

namespace raylinder.App.Web.Services;

public interface IExperienceService
{
    Task<IEnumerable<WorkExperience>> Get();
    Task<IEnumerable<Skill>> GetSkills();
}
