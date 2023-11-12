using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Data;
using PortfolioProject.Models;

[ApiController]
[Route("api/[controller]")]
public class SkillController : ControllerBase
{
    private PortfolioProjectDbContext _dbContext;

    public SkillController(PortfolioProjectDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetSkills()
    {
        return Ok(_dbContext.Skills.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetSkillDetails(int id)
    {
        Skill skill = _dbContext.Skills
            .Include(s => s.ProjectSkills)
            .ThenInclude(ps => ps.Project)
            .ThenInclude(p => p.ProjectTechnologies)
            .ThenInclude(pt => pt.Technology)
            .SingleOrDefault(s => s.Id == id);

            if (skill == null)
            {
                return NotFound();
            }

            return Ok(skill);
    }
}