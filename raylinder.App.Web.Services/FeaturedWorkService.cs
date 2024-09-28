
using System.Text.Json;
using raylinder.Entities;

namespace raylinder.App.Web.Services;

public class FeaturedWorkService : IFeaturedWorkService
{
    private readonly IBaseService _baseService;

    public FeaturedWorkService(IBaseService baseService)
    {
        _baseService = baseService;
    }

    public async Task<IEnumerable<WorkProject>> Get()
    {
        using var response = await _baseService.HttpClient.GetAsync("/GetProjects");

        if (!response.IsSuccessStatusCode || response.ReasonPhrase == "Unauthorized")
        {
            throw new Exception(response.ReasonPhrase);
        }

        return JsonSerializer.Deserialize<IEnumerable<WorkProject>>(await response.Content.ReadAsStringAsync(), _baseService.JsonSerializerOptions) ?? Array.Empty<WorkProject>();
    }
}
