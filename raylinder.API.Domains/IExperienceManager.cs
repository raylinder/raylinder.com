using raylinder.Entities;

namespace raylinder.API.Domains;

public interface IExperienceManager
{
    Task<IEnumerable<Skill>> GetSkills();
    Task<IEnumerable<WorkExperience>> GetWorkExperiences();
}
