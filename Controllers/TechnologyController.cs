using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Data;
using PortfolioProject.Models;

[ApiController]
[Route("api/[controller]")]
public class TechnologyController : ControllerBase
{
    private PortfolioProjectDbContext _dbContext;

    public TechnologyController(PortfolioProjectDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetTechnologies()
    {
        return Ok(_dbContext.Technologies.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetTechnologyDetails(int id)
    {
        Technology technology = _dbContext.Technologies
        .Include(t => t.ProjectTechnologies)
        .ThenInclude(pt => pt.Project)
        .ThenInclude(p => p.ProjectSkills)
        .ThenInclude(ps => ps.Skill)
        .SingleOrDefault(t => t.Id == id);

        if (technology == null)
        {
            return NotFound();
        }

        return Ok(technology);

    }
}