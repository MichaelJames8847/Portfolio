using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Data;
using PortfolioProject.Models;

[ApiController]
[Route("api/[controller]")]
public class CategoryController : ControllerBase
{
    private PortfolioProjectDbContext _dbContext;

    public CategoryController(PortfolioProjectDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    public IActionResult GetCategories()
    {
        return Ok(_dbContext.Categories.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetCategoryDetails(int id)
    {
        Category category = _dbContext.Categories
            .Include(c => c.BlogCategories)
            .ThenInclude(bc => bc.Blog)
            .ThenInclude(b => b.BlogInterests)
            .ThenInclude(bi => bi.Interest)
            .SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
    }
}