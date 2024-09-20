
namespace raylinder.API.Domains;

public class ExperienceManager : IExperienceManager
{
    public Task<double[]> GetTotals()
    {
        int[] _data = { 2018, 2017, 2017, 2016, 2011, 2012, 2004, 2004, 2004, 2018, 2010 };
        string[] _labels = { "Blazor", "React", "Angular", "ASP.NET Core", "ASP.NET MVC", "ASP.NET Web API", "ASP.NET Web Forms", "C#", "Microsoft SQL Server", "Neo4j", "Web Service API" };

        var arraySize = _data.Count();
        var totals = new double[arraySize];
        var i = 0;

        foreach (var yr in _data)
        {
            var total = DateTime.Now.Year - yr;

            totals[i] = total;
            _labels[i] = $"{_labels[i]} - {total} yrs";
            i++;
        }

        return Task.FromResult(totals);
    }
}
