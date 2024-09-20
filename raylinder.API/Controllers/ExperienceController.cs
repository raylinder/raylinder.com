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

    [HttpGet("GetTotals")]
    public async Task<JsonResult> Get() => new JsonResult(await _experienceManager.GetTotals());
}
