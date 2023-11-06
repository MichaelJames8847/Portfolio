namespace PortfolioProject.Models;

public class Technology
{
    public int Id { get; set; }
    public string TechnologyName { get; set; }
    public List<ProjectTechnology> ProjectTechnologies { get; set; }
    public List<Project> Projects { get; set; }
}