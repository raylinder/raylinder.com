using raylinder.Entities;

namespace raylinder.Repositories;

public class ExperienceRepository<T> : IExperienceRepository<T> where T : WorkExperience, new()
{
    private IEnumerable<T> _entitiesWorkExperiences;
    private IEnumerable<WorkExperienceDescription> _entitiesWorkExperienceDescriptions;
    private IEnumerable<Skill> _entitiesSkills;

    public ExperienceRepository()
    {
        _entitiesWorkExperiences = (IEnumerable<T>?)new Data.ExperienceData().WorkExperiences;
        _entitiesWorkExperienceDescriptions = new Data.ExperienceData().WorkExperienceDescriptions;
        _entitiesSkills = new Data.ExperienceData().Skills;
    }

    public Task<IEnumerable<T>> GetExperiences() => Task.FromResult(_entitiesWorkExperiences);

    public Task<IEnumerable<WorkExperienceDescription>> GetExperienceDescriptions() => Task.FromResult(_entitiesWorkExperienceDescriptions);

    public Task<IEnumerable<Skill>> GetSkills() => Task.FromResult(_entitiesSkills);
}
