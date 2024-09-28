
using raylinder.Entities;
using raylinder.Repositories;

namespace raylinder.Domains;

public class ExperienceDomain : IExperienceDomain
{
    private IExperienceRepository<WorkExperience> _experienceRepository;

    public ExperienceDomain(IExperienceRepository<WorkExperience> experienceRepository)
    {
        _experienceRepository = experienceRepository;
    }

    public async Task<IEnumerable<WorkExperience>> GetAllWorkExperiences()
    {
        var workExperiences = new List<WorkExperience>();
        var workExperiencesList = await _experienceRepository.GetExperiences();
        var workExperienceDescriptions = new List<WorkExperienceDescription>();
        var workExpereinceDescriptionsList = await _experienceRepository.GetExperienceDescriptions();

        foreach (var exp in workExperiencesList)
        {
            exp.Descriptions = workExpereinceDescriptionsList.Where(w => w.WorkExperienceId == exp.Id).ToList();

            workExperiences.Add(exp);
        }

        return await Task.FromResult(workExperiences);
    }

    public async Task<IEnumerable<Skill>> GetSkills()
    {
        var skills = new List<Skill>();
        var _year = DateTime.Now.Year;

        foreach (var skill in await _experienceRepository.GetSkills())
        {
            skill.TotalYears = _year - skill.Year;

            skills.Add(skill);
        }

        return skills;
    }
}
