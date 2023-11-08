using Microsoft.EntityFrameworkCore;
using PortfolioProject.Models;

public class PortfolioContext : DbContext
{
    private readonly IConfiguration _config;

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
            Title = "Blog test",
            Content = "Blog content",
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
                Description = @"Omni-Arena is your one stop shop for 
                the greatest fictional battles of all time! Pit some of your
                favorite characters from multiple universes against each other 
                and determine who's finally the strongest amongst them all!",
                StartDate = DateTime.Parse("2023-07-03"),
                EndDate = DateTime.Parse("2023-07-12"),
                Link = "https://github.com/MichaelJames8847/Omni-Arena-Capstone.git",
                Image = "https://i.kym-cdn.com/photos/images/newsfeed/000/993/683/3bc.jpg",
                ProjectStatus = "Complete"
            },

            new Project
            {
                Id = 2,
                Title = "DigitalDungeon",
                Description = @"DigitalDungeon is a platform where gamers can 
                come to find out their gaming adventure! Just register, select your
                prefered genres and preferences, and watch the magic unfurl
                as some of the most popular games in history are recommended for your
                pleasure!",
                StartDate = DateTime.Parse("2023-10-16"),
                EndDate = DateTime.Parse("2023-11-1"),
                Link = "https://github.com/MichaelJames8847/DigitalDungeon.git",
                Image = "https://offloadmedia.feverup.com/secretchicago.com/wp-content/uploads/2021/04/23044226/Gaming-Lounge-1024x554.jpg",
                ProjectStatus = "Complete"
            }
        });

        modelBuilder.Entity<Skill>().HasData(new Skill[]
        {
            new Skill
            { Id = 1, Name = "Test-Driven Development(TDD)"},
            new Skill
            { Id = 2, Name = "Agile and Scrum Methodologies"},
            new Skill
            { Id = 3, Name = "Problem-Solving"},
            new Skill
            { Id = 4, Name = "Critical Thinking"},
            new Skill
            { Id = 4, Name = "Project Management"},
            new Skill
            { Id = 5, Name = "Version Control (Git)"}
        });

        modelBuilder.Entity<Technology>().HasData(new Technology[]
        {
            new Technology
            { Id = 1, TechnologyName = "C#"},
            new Technology
            { Id = 2, TechnologyName = "ASP.NET"},
            new Technology
            { Id = 3, TechnologyName = "React.js"},
            new Technology
            { Id = 4, TechnologyName = "JavaScript"},
            new Technology
            { Id = 5, TechnologyName = "CSS"},
            new Technology
            { Id = 6, TechnologyName = "HTML"},
            new Technology
            { Id = 7, TechnologyName = "PostgreSQL"},
            new Technology
            { Id = 8, TechnologyName = "EFCore"},
            new Technology
            { Id = 9, TechnologyName = "Reactstrap"}
        });

        modelBuilder.Entity<ProjectSkill>().HasData(new ProjectSkill[]
        {
            new ProjectSkill
            { Id = 1, ProjectId = 1, SkillId = 1},
            new ProjectSkill
            { Id = 2, ProjectId = 1, SkillId = 2},
            new ProjectSkill
            { Id = 3, ProjectId = 1, SkillId = 3},
            new ProjectSkill
            { Id = 4, ProjectId = 1, SkillId = 4},
            new ProjectSkill
            { Id = 5, ProjectId = 1, SkillId = 5},
            new ProjectSkill
            { Id = 6, ProjectId = 2, SkillId = 1},
            new ProjectSkill
            { Id = 7, ProjectId = 2, SkillId = 2},
            new ProjectSkill
            { Id = 8, ProjectId = 2, SkillId = 3},
            new ProjectSkill
            { Id = 9, ProjectId = 2, SkillId = 4},
            new ProjectSkill
            { Id = 10, ProjectId = 2, SkillId = 5},
        });

        modelBuilder.Entity<ProjectTechnology>().HasData(new ProjectTechnology[]
        {
            new ProjectTechnology
            { Id = 1, ProjectId = 1, TechnologyId = 3},
            new ProjectTechnology
            { Id = 2, ProjectId = 1, TechnologyId = 4},
            new ProjectTechnology
            { Id = 3, ProjectId = 1, TechnologyId = 5},
            new ProjectTechnology
            { Id = 4, ProjectId = 1, TechnologyId = 6},
            new ProjectTechnology
            { Id = 5, ProjectId = 2, TechnologyId = 1},
            new ProjectTechnology
            { Id = 6, ProjectId = 2, TechnologyId = 2},
            new ProjectTechnology
            { Id = 7, ProjectId = 2, TechnologyId = 3},
            new ProjectTechnology
            { Id = 8, ProjectId = 2, TechnologyId = 4},
            new ProjectTechnology
            { Id = 9, ProjectId = 2, TechnologyId = 5},
            new ProjectTechnology
            { Id = 10, ProjectId = 2, TechnologyId = 7},
            new ProjectTechnology
            { Id = 11, ProjectId = 2, TechnologyId = 8},
            new ProjectTechnology
            { Id = 12, ProjectId = 2, TechnologyId = 9}
        });
    }
}