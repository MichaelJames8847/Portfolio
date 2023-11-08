// controller to handle all user profile api endpoints
// because of the naming of class UserProfileController, we are telling the framework 
// that the apis route would be api/"controller", or in this case, api/UserProfile
// first going to get user profile, and its information
// there are no tables connecting or relating to user profile in the database, 
// so endpoint should be quick and easy
using Microsoft.AspNetCore.Mvc;
using PortfolioProject.Data;

[ApiController]
[Route("api/[controller]")]
public class UserProfileController : ControllerBase
{
    private PortfolioProjectDbContext _dbContext;

    public UserProfileController(PortfolioProjectDbContext context)
    {
        _dbContext = context;
    }

    // GET user profiles from database
    // test in Swagger first before moving on
    // Had to configure launch.json to start 
    // easy and successful
    // no need for authorize tag as middlewear is not set up, and also not necessary since I will be only person
    // with any editing or posting power 
    [HttpGet]
    public IActionResult GetUserProfiles()
    {
        return Ok(_dbContext.UserProfiles.ToList());
    }
}