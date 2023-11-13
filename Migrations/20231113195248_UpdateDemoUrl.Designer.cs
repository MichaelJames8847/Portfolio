﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PortfolioProject.Data;

#nullable disable

namespace PortfolioProject.Migrations
{
    [DbContext(typeof(PortfolioProjectDbContext))]
    [Migration("20231113195248_UpdateDemoUrl")]
    partial class UpdateDemoUrl
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PortfolioProject.Models.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<int?>("InterestId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("PostDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("InterestId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Welcome to my first blog post!\r\n                    Today, I embark on a new journey - one that intertwines my passion for coding with my love for creativity. \r\n                    As a software engineer, I've always been fascinated by the way programming languages can create something out of nothing, \r\n                    turning lines of code into functional and impactful applications. \r\n                    But there's more to me than just my profession.\r\n\r\n                    Music: My Melodic Escape\r\n                    Music has always been my sanctuary. \r\n                    Whether I'm strumming the guitar or getting lost in the rhythmic beats of drums, \r\n                    it's where I find peace. It's not just a hobby; it's a part of who I am. \r\n                    It influences how I think and solve problems. \r\n                    The creativity and discipline I learn from music often spill over into my coding, \r\n                    bringing a sense of rhythm and flow to my work.\r\n\r\n                    Gaming: The Virtual Odyssey\r\n                    I'm an avid gamer, and gaming is where I turn to when I need a break from the world. It's fascinating to see \r\n                    how intricate designs and complex storylines come together to create immersive experiences. \r\n                    As a developer, I draw inspiration from these virtual worlds, reminding myself of the importance of user experience and engagement.\r\n\r\n                    Fitness: Balancing the Mind and Body\r\n                    Maintaining a balance between the mind and body is crucial. \r\n                    For me, fitness is not just about physical health but mental well-being. Hitting the gym or going for a run \r\n                    clears my mind and prepares me for the challenges ahead. \r\n                    It's during these moments of clarity that some of my best ideas come to life.\r\n\r\n                    The Journey Ahead\r\n                    As I continue on this path, I aim to bring together these diverse elements - \r\n                    the logic of code, the creativity of music, the engagement of gaming, and the discipline of fitness - \r\n                    to create something unique. In this blog, I'll share my experiences, challenges, and learnings in software development and beyond.\r\n\r\n                    From exploring new programming languages and technologies to delving into web development, UI/UX design, and project management, \r\n                    I'll document it all here. I hope to connect with like-minded individuals, learn from this community, and grow as both a developer and a person.\r\n\r\n                    So, stay tuned, and let's embark on this journey together!",
                            Image = "https://res.cloudinary.com/practicaldev/image/fetch/s--VjOTp9uS--/c_imagga_scale,f_auto,fl_progressive,h_420,q_auto,w_1000/https://dev-to-uploads.s3.amazonaws.com/i/2o2t0fyzszqheinl9x7a.png",
                            PostDate = new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Embracing the Journey: A Blend of Coding and Creativity"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.BlogCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("integer");

                    b.Property<int>("CategoryId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("CategoryId");

                    b.ToTable("BlogCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            CategoryId = 6
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.BlogInterest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("BlogId")
                        .HasColumnType("integer");

                    b.Property<int>("InterestId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.HasIndex("InterestId");

                    b.ToTable("BlogInterests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 1,
                            InterestId = 1
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 1,
                            InterestId = 2
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 1,
                            InterestId = 4
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Programming Languages"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Web Development"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Database Design"
                        },
                        new
                        {
                            Id = 4,
                            CategoryName = "Project Management"
                        },
                        new
                        {
                            Id = 5,
                            CategoryName = "UI/UX Design"
                        },
                        new
                        {
                            Id = 6,
                            CategoryName = "Personal Reflections"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.Interest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Interests");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Music"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Video Games"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Girlfriend"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Working Out"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Demo")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Image")
                        .HasColumnType("text");

                    b.Property<string>("Link")
                        .HasColumnType("text");

                    b.Property<string>("ProjectStatus")
                        .HasColumnType("text");

                    b.Property<int?>("SkillId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("TechnologyId")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Omni-Arena is your one stop shop for \r\n                the greatest fictional battles of all time! Pit some of your\r\n                favorite characters from multiple universes against each other \r\n                and determine who's finally the strongest amongst them all!",
                            EndDate = new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Utc),
                            Image = "https://i.kym-cdn.com/photos/images/newsfeed/000/993/683/3bc.jpg",
                            Link = "https://github.com/MichaelJames8847/Omni-Arena-Capstone.git",
                            ProjectStatus = "Complete",
                            StartDate = new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "Omni-Arena"
                        },
                        new
                        {
                            Id = 2,
                            Demo = "https://www.loom.com/share/8cefd393719347a28ee318e221b7b386?sid=66e4151a-88a6-4779-97f5-70e15744e175",
                            Description = "DigitalDungeon is a platform where gamers can \r\n                come to find out their gaming adventure! Just register, select your\r\n                prefered genres and preferences, and watch the magic unfurl\r\n                as some of the most popular games in history are recommended for your\r\n                pleasure!",
                            EndDate = new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc),
                            Image = "https://offloadmedia.feverup.com/secretchicago.com/wp-content/uploads/2021/04/23044226/Gaming-Lounge-1024x554.jpg",
                            Link = "https://github.com/MichaelJames8847/DigitalDungeon.git",
                            ProjectStatus = "Complete",
                            StartDate = new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc),
                            Title = "DigitalDungeon"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.ProjectSkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<int>("SkillId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("SkillId");

                    b.ToTable("ProjectSkills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProjectId = 1,
                            SkillId = 1
                        },
                        new
                        {
                            Id = 2,
                            ProjectId = 1,
                            SkillId = 2
                        },
                        new
                        {
                            Id = 3,
                            ProjectId = 1,
                            SkillId = 3
                        },
                        new
                        {
                            Id = 4,
                            ProjectId = 1,
                            SkillId = 4
                        },
                        new
                        {
                            Id = 5,
                            ProjectId = 1,
                            SkillId = 5
                        },
                        new
                        {
                            Id = 6,
                            ProjectId = 2,
                            SkillId = 1
                        },
                        new
                        {
                            Id = 7,
                            ProjectId = 2,
                            SkillId = 2
                        },
                        new
                        {
                            Id = 8,
                            ProjectId = 2,
                            SkillId = 3
                        },
                        new
                        {
                            Id = 9,
                            ProjectId = 2,
                            SkillId = 4
                        },
                        new
                        {
                            Id = 10,
                            ProjectId = 2,
                            SkillId = 5
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.ProjectTechnology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("ProjectId")
                        .HasColumnType("integer");

                    b.Property<int>("TechnologyId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.HasIndex("TechnologyId");

                    b.ToTable("ProjectTechnologies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ProjectId = 1,
                            TechnologyId = 3
                        },
                        new
                        {
                            Id = 2,
                            ProjectId = 1,
                            TechnologyId = 4
                        },
                        new
                        {
                            Id = 3,
                            ProjectId = 1,
                            TechnologyId = 5
                        },
                        new
                        {
                            Id = 4,
                            ProjectId = 1,
                            TechnologyId = 6
                        },
                        new
                        {
                            Id = 5,
                            ProjectId = 2,
                            TechnologyId = 1
                        },
                        new
                        {
                            Id = 6,
                            ProjectId = 2,
                            TechnologyId = 2
                        },
                        new
                        {
                            Id = 7,
                            ProjectId = 2,
                            TechnologyId = 3
                        },
                        new
                        {
                            Id = 8,
                            ProjectId = 2,
                            TechnologyId = 4
                        },
                        new
                        {
                            Id = 9,
                            ProjectId = 2,
                            TechnologyId = 5
                        },
                        new
                        {
                            Id = 10,
                            ProjectId = 2,
                            TechnologyId = 7
                        },
                        new
                        {
                            Id = 11,
                            ProjectId = 2,
                            TechnologyId = 8
                        },
                        new
                        {
                            Id = 12,
                            ProjectId = 2,
                            TechnologyId = 9
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Skills");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Test-Driven Development(TDD)"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Agile and Scrum Methodologies"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Problem-Solving"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Critical Thinking"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Project Management"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Version Control (Git)"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.Technology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("TechnologyName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Technologies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TechnologyName = "C#"
                        },
                        new
                        {
                            Id = 2,
                            TechnologyName = "ASP.NET"
                        },
                        new
                        {
                            Id = 3,
                            TechnologyName = "React.js"
                        },
                        new
                        {
                            Id = 4,
                            TechnologyName = "JavaScript"
                        },
                        new
                        {
                            Id = 5,
                            TechnologyName = "CSS"
                        },
                        new
                        {
                            Id = 6,
                            TechnologyName = "HTML"
                        },
                        new
                        {
                            Id = 7,
                            TechnologyName = "PostgreSQL"
                        },
                        new
                        {
                            Id = 8,
                            TechnologyName = "EFCore"
                        },
                        new
                        {
                            Id = 9,
                            TechnologyName = "Reactstrap"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.UserProfile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Bio")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Github")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("LinkedIn")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<string>("ProfilePic")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("UserProfiles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Former Executive Chef turned Full Stack Web Developer. My journey in the culinary worl\r\n            spanned 15 years, starting as a humble dishwasher and culminating in a leadership role at \r\n            BJ's Restaurant and Brewhouse, of where I housed 8 years of my professional work life.\r\n            This path taught me the essence of hard work, teamwork, and the art of managing high-pressure situations.\r\n            \r\n            In May 2023, I embarkned on a new adventure, driven by my passion for technology and problem-solving.\r\n            I joined the Full Time, Full Stack Web Development Cohort-65 at Nashville Software School(NSS), where I\r\n            honed my skills in Javascript(JS), React.js, C#, ASP.NET, and so many more. This intensive program not only\r\n            equipped me with technical skills, but also deepened my ability to think logically and creatively.\r\n            \r\n            Beyond coding and cooking, I'm an avid gamer and a musician at heart. You'll often find me lost in the\r\n            world of games or expressing myself through the strings of a guitar, the beats of drums, or belting away\r\n            in the microphone. This blend of creativity and technical acumen is what I bring to the world of\r\n            web development.\r\n            \r\n            As I transition into this exciting industry, I'm eagerly seeking opportunities to contribute, grow,\r\n            and collaborate. I am passionate about creating impactful, user-friendly applications and am constantly\r\n            exploring new technologies and apporaches to enhance my skills.\r\n            \r\n            Thank you for visiting my portfolio. Dive in to see the projects that showcase my journey from kitchens to code,\r\n            and feel free to reach out if you think my skills and passions align with your needs.",
                            Email = "jmj6ggggg@gmail.com",
                            FirstName = "Michael",
                            Github = "https://github.com/MichaelJames8847",
                            LastName = "James",
                            LinkedIn = "https://www.linkedin.com/in/michaeljames8847/",
                            PhoneNumber = "615-971-9745",
                            ProfilePic = "https://avatars.githubusercontent.com/u/133455651?v=4"
                        });
                });

            modelBuilder.Entity("PortfolioProject.Models.Blog", b =>
                {
                    b.HasOne("PortfolioProject.Models.Category", null)
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId");

                    b.HasOne("PortfolioProject.Models.Interest", null)
                        .WithMany("Blogs")
                        .HasForeignKey("InterestId");
                });

            modelBuilder.Entity("PortfolioProject.Models.BlogCategory", b =>
                {
                    b.HasOne("PortfolioProject.Models.Blog", "Blog")
                        .WithMany("BlogCategories")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortfolioProject.Models.Category", "Category")
                        .WithMany("BlogCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PortfolioProject.Models.BlogInterest", b =>
                {
                    b.HasOne("PortfolioProject.Models.Blog", "Blog")
                        .WithMany("BlogInterests")
                        .HasForeignKey("BlogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortfolioProject.Models.Interest", "Interest")
                        .WithMany("BlogInterests")
                        .HasForeignKey("InterestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Blog");

                    b.Navigation("Interest");
                });

            modelBuilder.Entity("PortfolioProject.Models.Project", b =>
                {
                    b.HasOne("PortfolioProject.Models.Skill", null)
                        .WithMany("Projects")
                        .HasForeignKey("SkillId");

                    b.HasOne("PortfolioProject.Models.Technology", null)
                        .WithMany("Projects")
                        .HasForeignKey("TechnologyId");
                });

            modelBuilder.Entity("PortfolioProject.Models.ProjectSkill", b =>
                {
                    b.HasOne("PortfolioProject.Models.Project", "Project")
                        .WithMany("ProjectSkills")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortfolioProject.Models.Skill", "Skill")
                        .WithMany("ProjectSkills")
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("PortfolioProject.Models.ProjectTechnology", b =>
                {
                    b.HasOne("PortfolioProject.Models.Project", "Project")
                        .WithMany("ProjectTechnologies")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PortfolioProject.Models.Technology", "Technology")
                        .WithMany("ProjectTechnologies")
                        .HasForeignKey("TechnologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("Technology");
                });

            modelBuilder.Entity("PortfolioProject.Models.Blog", b =>
                {
                    b.Navigation("BlogCategories");

                    b.Navigation("BlogInterests");
                });

            modelBuilder.Entity("PortfolioProject.Models.Category", b =>
                {
                    b.Navigation("BlogCategories");

                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("PortfolioProject.Models.Interest", b =>
                {
                    b.Navigation("BlogInterests");

                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("PortfolioProject.Models.Project", b =>
                {
                    b.Navigation("ProjectSkills");

                    b.Navigation("ProjectTechnologies");
                });

            modelBuilder.Entity("PortfolioProject.Models.Skill", b =>
                {
                    b.Navigation("ProjectSkills");

                    b.Navigation("Projects");
                });

            modelBuilder.Entity("PortfolioProject.Models.Technology", b =>
                {
                    b.Navigation("ProjectTechnologies");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}