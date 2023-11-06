namespace PortfolioProject.Models;

public class Project
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public string Link { get; set; }
    public string Image { get; set; }
    public string ProjectStatus { get; set; }
    public List<ProjectSkill> ProjectSkills { get; set; }
    public List<ProjectTechnology> ProjectTechnologies { get; set; }
}