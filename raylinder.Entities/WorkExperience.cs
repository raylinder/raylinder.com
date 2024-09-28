namespace raylinder.Entities;

public class WorkExperience
{
    public Guid Id { get; set; }
    public string? Title { get; set; }
    public string? CompanyName { get; set; }
    public string? Dates { get; set; }
    public string? Location { get; set; }
    public List<WorkExperienceDescription>? Descriptions { get; set; }
    public string? ImageUrl { get; set; }
    public string? Alignment { get; set; }
    public Guid? ParentId { get; set; }
}
