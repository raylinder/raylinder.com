
using raylinder.Domains;
using raylinder.Entities;

namespace raylinder.API.Domains;

public class ExperienceManager : IExperienceManager
{
    private readonly IExperienceDomain _experienceDomain;

    public ExperienceManager(IExperienceDomain experienceDomain)
    {
        _experienceDomain = experienceDomain;
    }

    public async Task<IEnumerable<WorkExperience>> GetWorkExperiences()
    {
        return await _experienceDomain.GetAllWorkExperiences();
    }

    public async Task<IEnumerable<Skill>> GetSkills()
    {
        return await _experienceDomain.GetSkills();
    }
}
