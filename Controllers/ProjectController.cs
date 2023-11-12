using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Data;
using PortfolioProject.Models;

[ApiController]
[Route("api/[controller]")]
public class ProjectController : ControllerBase
{
    private PortfolioProjectDbContext _dbContext;

    public ProjectController(PortfolioProjectDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetProjects()
    {
        return Ok(_dbContext.Projects.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetProjectDetails(int id)
    {
        Project project = _dbContext.Projects
            .Include(p => p.ProjectSkills)
            .ThenInclude(ps => ps.Skill)
            .Include(p => p.ProjectTechnologies)
            .ThenInclude(pt => pt.Technology)
            .SingleOrDefault(p => p.Id == id);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
    }
}