using Microsoft.AspNetCore.Mvc;
using raylinder.API.Domains;

namespace raylinder.API.Controllers;

public class ExperienceController : Controller
{
    private readonly IExperienceManager _experienceManager;

    public ExperienceController(IExperienceManager experienceManager)
    {
        _experienceManager = experienceManager;
    }

    [HttpGet("GetWorkExperiences")]
    public async Task<JsonResult> Get() => new JsonResult(await _experienceManager.GetWorkExperiences());

    [HttpGet("GetSkills")]
    public async Task<JsonResult> GetTotals() => new JsonResult(await _experienceManager.GetSkills());
}
