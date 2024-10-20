using raylinder.Entities;
using System.Text.Json;

namespace raylinder.App.Services;

public class ExperienceService : IExperienceService
{
    private readonly IBaseService _baseService;

    public ExperienceService(IBaseService baseService)
    {
        _baseService = baseService;
    }

    public async Task<IEnumerable<WorkExperience>> Get()
    {
        using var response = await _baseService.HttpClient.GetAsync("/GetWorkExperiences");

        if (!response.IsSuccessStatusCode || response.ReasonPhrase == "Unauthorized")
        {
            throw new Exception(response.ReasonPhrase);
        }

        return JsonSerializer.Deserialize<IEnumerable<WorkExperience>>(await response.Content.ReadAsStringAsync(), _baseService.JsonSerializerOptions) ?? new List<WorkExperience>();
    }

    public async Task<IEnumerable<Skill>> GetSkills()
    {
        using var response = await _baseService.HttpClient.GetAsync("/GetSkills");

        if (!response.IsSuccessStatusCode || response.ReasonPhrase == "Unauthorized")
        {
            throw new Exception(response.ReasonPhrase);
        }

        return JsonSerializer.Deserialize<IEnumerable<Skill>>(await response.Content.ReadAsStringAsync(), _baseService.JsonSerializerOptions) ?? new List<Skill>();
    }
}
