using Humanizer;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Models;

public class PortfolioContext : DbContext
{
    private readonly IConfiguration _config;

    public PortfolioContext(DbContextOptions<PortfolioContext> options)
        :base(options)
        {

        }

    public PortfolioContext(DbContextOptions<PortfolioContext> options, IConfiguration config)
        :base (options)
        {
            _config = config;
        }

    public DbSet<Blog> Blogs { get; set; }
    public DbSet<BlogCategory> BlogCategories { get; set; }
    public DbSet<BlogInterest> BlogInterests { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Interest> Interests { get; set; }
    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectSkill> ProjectSkills { get; set; }
    public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }
    public DbSet<Skill> Skills { get; set; }
    public DbSet<Technology> Technologies { get; set; }
    public DbSet<UserProfile> UserProfiles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<UserProfile>().HasData(new UserProfile
        {
            Id = 1,
            FirstName = "Michael",
            LastName = "James",
            ProfilePic = "https://avatars.githubusercontent.com/u/133455651?v=4",
            Bio = "A Short Bio",
            Email = "jmj6ggggg@gmail.com",
            PhoneNumber = "615-971-9745",
            LinkedIn = "https://www.linkedin.com/in/michaeljames8847/",
            Github = "https://github.com/MichaelJames8847"
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 1,
            Title = "Bio test",
            Content = "Bio content",
            PostDate = DateTime.UtcNow,
            Image = "null"
        });

        modelBuilder.Entity<BlogCategory>().HasData(new BlogCategory
        {
            Id = 1,
            BlogId = 1,
            CategoryId = 1
        });

        modelBuilder.Entity<BlogInterest>().HasData(new BlogInterest
        {
            Id = 1,
            BlogId = 1,
            InterestId = 1
        });

        modelBuilder.Entity<Category>().HasData(new Category[]
        {
            new Category { Id = 1, CategoryName = "Programming Languages"},
            new Category { Id = 2, CategoryName = "Web Development"},
            new Category { Id = 3, CategoryName = "Database Design"},
            new Category { Id = 4, CategoryName = "Project Management"},
            new Category { Id = 5, CategoryName = "UI/UX Design"},
            new Category { Id = 6, CategoryName = "Personal Reflections"}
        });

        modelBuilder.Entity<Interest>().HasData(new Interest[]
        {
            new Interest { Id = 1, Name = "Music"},
            new Interest { Id = 2, Name = "Video Games"},
            new Interest { Id = 3, Name = "Girlfriend"},
            new Interest { Id = 4, Name = "Working Out"}
        });

        modelBuilder.Entity<Project>().HasData(new Project[]
        {
            new Project 
            {
                Id = 1,
                Title = "Omni-Arena",
                
            }
        })
    }

}