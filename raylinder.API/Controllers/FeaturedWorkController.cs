using Microsoft.AspNetCore.Mvc;
using raylinder.API.Domains;

namespace raylinder.API.Controllers;

public class FeaturedWorkController : Controller
{
    private readonly IFeaturedWorkManager _featuredWorkManager;

    public FeaturedWorkController(IFeaturedWorkManager featuredWorkManager)
    {
        _featuredWorkManager = featuredWorkManager;
    }

    [HttpGet("GetProjects")]
    public async Task<JsonResult> Get() => new JsonResult(await _featuredWorkManager.GetWorkProjects());
}
