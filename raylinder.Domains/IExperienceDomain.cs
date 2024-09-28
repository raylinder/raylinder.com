using raylinder.Entities;

namespace raylinder.Domains;

public interface IExperienceDomain
{
    Task<IEnumerable<WorkExperience>> GetAllWorkExperiences();
    Task<IEnumerable<Skill>> GetSkills();
}