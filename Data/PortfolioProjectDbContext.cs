using Microsoft.EntityFrameworkCore;
using PortfolioProject.Models;

namespace PortfolioProject.Data;
public class PortfolioProjectDbContext : DbContext
{
    private readonly IConfiguration _config;

    public PortfolioProjectDbContext(DbContextOptions<PortfolioProjectDbContext> options, IConfiguration config)
        : base(options)
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
            Bio = @"Former Executive Chef turned Full Stack Web Developer. My journey in the culinary worl
            spanned 15 years, starting as a humble dishwasher and culminating in a leadership role at 
            BJ's Restaurant and Brewhouse, of where I housed 8 years of my professional work life.
            This path taught me the essence of hard work, teamwork, and the art of managing high-pressure situations.
            
            In May 2023, I embarkned on a new adventure, driven by my passion for technology and problem-solving.
            I joined the Full Time, Full Stack Web Development Cohort-65 at Nashville Software School(NSS), where I
            honed my skills in Javascript(JS), React.js, C#, ASP.NET, and so many more. This intensive program not only
            equipped me with technical skills, but also deepened my ability to think logically and creatively.
            
            Beyond coding and cooking, I'm an avid gamer and a musician at heart. You'll often find me lost in the
            world of games or expressing myself through the strings of a guitar, the beats of drums, or belting away
            in the microphone. This blend of creativity and technical acumen is what I bring to the world of
            web development.
            
            As I transition into this exciting industry, I'm eagerly seeking opportunities to contribute, grow,
            and collaborate. I am passionate about creating impactful, user-friendly applications and am constantly
            exploring new technologies and apporaches to enhance my skills.
            
            Thank you for visiting my portfolio. Dive in to see the projects that showcase my journey from kitchens to code,
            and feel free to reach out if you think my skills and passions align with your needs.",
            Email = "jmj6ggggg@gmail.com",
            PhoneNumber = "615-971-9745",
            LinkedIn = "https://www.linkedin.com/in/michaeljames8847/",
            Github = "https://github.com/MichaelJames8847"
        });

        modelBuilder.Entity<Blog>().HasData(new Blog
        {
            Id = 1,
            Title = "Embracing the Journey: A Blend of Coding and Creativity",
            Content = @"Welcome to my first blog post!
                    Today, I embark on a new journey - one that intertwines my passion for coding with my love for creativity. 
                    As a software engineer, I've always been fascinated by the way programming languages can create something out of nothing, 
                    turning lines of code into functional and impactful applications. 
                    But there's more to me than just my profession.

                    Music: My Melodic Escape
                    Music has always been my sanctuary. 
                    Whether I'm strumming the guitar or getting lost in the rhythmic beats of drums, 
                    it's where I find peace. It's not just a hobby; it's a part of who I am. 
                    It influences how I think and solve problems. 
                    The creativity and discipline I learn from music often spill over into my coding, 
                    bringing a sense of rhythm and flow to my work.

                    Gaming: The Virtual Odyssey
                    I'm an avid gamer, and gaming is where I turn to when I need a break from the world. It's fascinating to see 
                    how intricate designs and complex storylines come together to create immersive experiences. 
                    As a developer, I draw inspiration from these virtual worlds, reminding myself of the importance of user experience and engagement.

                    Fitness: Balancing the Mind and Body
                    Maintaining a balance between the mind and body is crucial. 
                    For me, fitness is not just about physical health but mental well-being. Hitting the gym or going for a run 
                    clears my mind and prepares me for the challenges ahead. 
                    It's during these moments of clarity that some of my best ideas come to life.

                    The Journey Ahead
                    As I continue on this path, I aim to bring together these diverse elements - 
                    the logic of code, the creativity of music, the engagement of gaming, and the discipline of fitness - 
                    to create something unique. In this blog, I'll share my experiences, challenges, and learnings in software development and beyond.

                    From exploring new programming languages and technologies to delving into web development, UI/UX design, and project management, 
                    I'll document it all here. I hope to connect with like-minded individuals, learn from this community, and grow as both a developer and a person.

                    So, stay tuned, and let's embark on this journey together!",
            PostDate = DateTime.SpecifyKind(DateTime.Parse("2023-11-08"), DateTimeKind.Utc),
            Image = "https://res.cloudinary.com/practicaldev/image/fetch/s--VjOTp9uS--/c_imagga_scale,f_auto,fl_progressive,h_420,q_auto,w_1000/https://dev-to-uploads.s3.amazonaws.com/i/2o2t0fyzszqheinl9x7a.png"
        });

        modelBuilder.Entity<BlogCategory>().HasData(new BlogCategory
        {
            Id = 1,
            BlogId = 1,
            CategoryId = 6
        });

        modelBuilder.Entity<BlogInterest>().HasData(new BlogInterest[]
        {
            new BlogInterest
            {
                Id = 1,
                BlogId = 1,
                InterestId = 1
            },
            new BlogInterest
            {
                Id = 2,
                BlogId = 1,
                InterestId = 2
            },
            new BlogInterest
            {
                Id = 3,
                BlogId = 1,
                InterestId = 4
            }
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
                StartDate = DateTime.SpecifyKind(DateTime.Parse("2023-07-03"), DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(DateTime.Parse("2023-07-12"), DateTimeKind.Utc),
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
                StartDate = DateTime.SpecifyKind(DateTime.Parse("2023-10-19"), DateTimeKind.Utc),
                EndDate = DateTime.SpecifyKind(DateTime.Parse("2023-11-1"), DateTimeKind.Utc),
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
            { Id = 5, Name = "Project Management"},
            new Skill
            { Id = 6, Name = "Version Control (Git)"}
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