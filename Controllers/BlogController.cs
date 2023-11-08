using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Data;
using PortfolioProject.Models;

[ApiController]
[Route("api/[controller]")]
public class BlogController : ControllerBase
{
    private PortfolioProjectDbContext _dbContext;

    public BlogController(PortfolioProjectDbContext context)
    {
        _dbContext = context;
    }

    [HttpGet]
    // unexpected JSON exception error, mentioning a potential of an infinite loop 
    // for blog categories. Unsure of as to why right now
    // realized was really creating an endpoint for getting blog details
    // which should be for getting a blog by id
    // lets do that now
    public IActionResult GetBlogs()
    {
       return Ok (_dbContext.Blogs
            .ToList());
    }

    // received the same error for this endpoint. Apparently, you must configure
    // program.cs to ignore cycles in order to prevent endless loop for includes
    // configured and working appropriately, but need to reconfigure endpoint to include 
    // data about categories and interests
    [HttpGet("{id}")]
    public IActionResult GetBlogDetails(int id)
    {
        Blog blog = _dbContext.Blogs
            .Include(b => b.BlogCategories)
            .ThenInclude(bc => bc.Category)
            .Include(b => b.BlogInterests)
            .ThenInclude(bi => bi.Interest)
            .SingleOrDefault(b => b.Id == id);

            // error handling for if blog is not found

            if (blog == null)
            {
                return NotFound();
            }

            return Ok(blog);
    }
}