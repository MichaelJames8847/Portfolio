using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CategoryName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Interests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Interests", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Technologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TechnologyName = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technologies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    LastName = table.Column<string>(type: "text", nullable: true),
                    ProfilePic = table.Column<string>(type: "text", nullable: true),
                    Bio = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    LinkedIn = table.Column<string>(type: "text", nullable: true),
                    Github = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Content = table.Column<string>(type: "text", nullable: true),
                    PostDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Image = table.Column<string>(type: "text", nullable: true),
                    CategoryId = table.Column<int>(type: "integer", nullable: true),
                    InterestId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Blogs_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    StartDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Link = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(type: "text", nullable: true),
                    ProjectStatus = table.Column<string>(type: "text", nullable: true),
                    Demo = table.Column<string>(type: "text", nullable: true),
                    SkillId = table.Column<int>(type: "integer", nullable: true),
                    TechnologyId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Projects_Technologies_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technologies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlogCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlogId = table.Column<int>(type: "integer", nullable: false),
                    CategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogCategories_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogInterests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    BlogId = table.Column<int>(type: "integer", nullable: false),
                    InterestId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogInterests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogInterests_Blogs_BlogId",
                        column: x => x.BlogId,
                        principalTable: "Blogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogInterests_Interests_InterestId",
                        column: x => x.InterestId,
                        principalTable: "Interests",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSkills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSkills", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProjectTechnologies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProjectId = table.Column<int>(type: "integer", nullable: false),
                    TechnologyId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectTechnologies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectTechnologies_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProjectTechnologies_Technologies_TechnologyId",
                        column: x => x.TechnologyId,
                        principalTable: "Technologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CategoryId", "Content", "Image", "InterestId", "PostDate", "Title" },
                values: new object[] { 1, null, "Welcome to my first blog post!\r\n                    Today, I embark on a new journey - one that intertwines my passion for coding with my love for creativity. \r\n                    As a software engineer, I've always been fascinated by the way programming languages can create something out of nothing, \r\n                    turning lines of code into functional and impactful applications. \r\n                    But there's more to me than just my profession.\r\n\r\n                    Music: My Melodic Escape\r\n                    Music has always been my sanctuary. \r\n                    Whether I'm strumming the guitar or getting lost in the rhythmic beats of drums, \r\n                    it's where I find peace. It's not just a hobby; it's a part of who I am. \r\n                    It influences how I think and solve problems. \r\n                    The creativity and discipline I learn from music often spill over into my coding, \r\n                    bringing a sense of rhythm and flow to my work.\r\n\r\n                    Gaming: The Virtual Odyssey\r\n                    I'm an avid gamer, and gaming is where I turn to when I need a break from the world. It's fascinating to see \r\n                    how intricate designs and complex storylines come together to create immersive experiences. \r\n                    As a developer, I draw inspiration from these virtual worlds, reminding myself of the importance of user experience and engagement.\r\n\r\n                    Fitness: Balancing the Mind and Body\r\n                    Maintaining a balance between the mind and body is crucial. \r\n                    For me, fitness is not just about physical health but mental well-being. Hitting the gym or going for a run \r\n                    clears my mind and prepares me for the challenges ahead. \r\n                    It's during these moments of clarity that some of my best ideas come to life.\r\n\r\n                    The Journey Ahead\r\n                    As I continue on this path, I aim to bring together these diverse elements - \r\n                    the logic of code, the creativity of music, the engagement of gaming, and the discipline of fitness - \r\n                    to create something unique. In this blog, I'll share my experiences, challenges, and learnings in software development and beyond.\r\n\r\n                    From exploring new programming languages and technologies to delving into web development, UI/UX design, and project management, \r\n                    I'll document it all here. I hope to connect with like-minded individuals, learn from this community, and grow as both a developer and a person.\r\n\r\n                    So, stay tuned, and let's embark on this journey together!", "https://res.cloudinary.com/practicaldev/image/fetch/s--VjOTp9uS--/c_imagga_scale,f_auto,fl_progressive,h_420,q_auto,w_1000/https://dev-to-uploads.s3.amazonaws.com/i/2o2t0fyzszqheinl9x7a.png", null, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Embracing the Journey: A Blend of Coding and Creativity" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Programming Languages" },
                    { 2, "Web Development" },
                    { 3, "Database Design" },
                    { 4, "Project Management" },
                    { 5, "UI/UX Design" },
                    { 6, "Personal Reflections" }
                });

            migrationBuilder.InsertData(
                table: "Interests",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Music" },
                    { 2, "Video Games" },
                    { 3, "Girlfriend" },
                    { 4, "Working Out" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "Demo", "Description", "EndDate", "Image", "Link", "ProjectStatus", "SkillId", "StartDate", "TechnologyId", "Title" },
                values: new object[,]
                {
                    { 1, null, "Omni-Arena is your one stop shop for \r\n                the greatest fictional battles of all time! Pit some of your\r\n                favorite characters from multiple universes against each other \r\n                and determine who's finally the strongest amongst them all!", new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Utc), "https://i.kym-cdn.com/photos/images/newsfeed/000/993/683/3bc.jpg", "https://github.com/MichaelJames8847/Omni-Arena-Capstone.git", "Complete", null, new DateTime(2023, 7, 3, 0, 0, 0, 0, DateTimeKind.Utc), null, "Omni-Arena" },
                    { 2, "https://www.loom.com/share/8cefd393719347a28ee318e221b7b386?sid=2e2266bf-d7fb-4a43-b227-3df54e75e4e2", "DigitalDungeon is a platform where gamers can \r\n                come to find out their gaming adventure! Just register, select your\r\n                prefered genres and preferences, and watch the magic unfurl\r\n                as some of the most popular games in history are recommended for your\r\n                pleasure!", new DateTime(2023, 11, 1, 0, 0, 0, 0, DateTimeKind.Utc), "https://offloadmedia.feverup.com/secretchicago.com/wp-content/uploads/2021/04/23044226/Gaming-Lounge-1024x554.jpg", "https://github.com/MichaelJames8847/DigitalDungeon.git", "Complete", null, new DateTime(2023, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), null, "DigitalDungeon" }
                });

            migrationBuilder.InsertData(
                table: "Skills",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Test-Driven Development(TDD)" },
                    { 2, "Agile and Scrum Methodologies" },
                    { 3, "Problem-Solving" },
                    { 4, "Critical Thinking" },
                    { 5, "Project Management" },
                    { 6, "Version Control (Git)" }
                });

            migrationBuilder.InsertData(
                table: "Technologies",
                columns: new[] { "Id", "TechnologyName" },
                values: new object[,]
                {
                    { 1, "C#" },
                    { 2, "ASP.NET" },
                    { 3, "React.js" },
                    { 4, "JavaScript" },
                    { 5, "CSS" },
                    { 6, "HTML" },
                    { 7, "PostgreSQL" },
                    { 8, "EFCore" },
                    { 9, "Reactstrap" }
                });

            migrationBuilder.InsertData(
                table: "UserProfiles",
                columns: new[] { "Id", "Bio", "Email", "FirstName", "Github", "LastName", "LinkedIn", "PhoneNumber", "ProfilePic" },
                values: new object[] { 1, "Former Executive Chef turned Full Stack Web Developer. My journey in the culinary worl\r\n            spanned 15 years, starting as a humble dishwasher and culminating in a leadership role at \r\n            BJ's Restaurant and Brewhouse, of where I housed 8 years of my professional work life.\r\n            This path taught me the essence of hard work, teamwork, and the art of managing high-pressure situations.\r\n            \r\n            In May 2023, I embarkned on a new adventure, driven by my passion for technology and problem-solving.\r\n            I joined the Full Time, Full Stack Web Development Cohort-65 at Nashville Software School(NSS), where I\r\n            honed my skills in Javascript(JS), React.js, C#, ASP.NET, and so many more. This intensive program not only\r\n            equipped me with technical skills, but also deepened my ability to think logically and creatively.\r\n            \r\n            Beyond coding and cooking, I'm an avid gamer and a musician at heart. You'll often find me lost in the\r\n            world of games or expressing myself through the strings of a guitar, the beats of drums, or belting away\r\n            in the microphone. This blend of creativity and technical acumen is what I bring to the world of\r\n            web development.\r\n            \r\n            As I transition into this exciting industry, I'm eagerly seeking opportunities to contribute, grow,\r\n            and collaborate. I am passionate about creating impactful, user-friendly applications and am constantly\r\n            exploring new technologies and apporaches to enhance my skills.\r\n            \r\n            Thank you for visiting my portfolio. Dive in to see the projects that showcase my journey from kitchens to code,\r\n            and feel free to reach out if you think my skills and passions align with your needs.", "jmj6ggggg@gmail.com", "Michael", "https://github.com/MichaelJames8847", "James", "https://www.linkedin.com/in/michaeljames8847/", "615-971-9745", "https://avatars.githubusercontent.com/u/133455651?v=4" });

            migrationBuilder.InsertData(
                table: "BlogCategories",
                columns: new[] { "Id", "BlogId", "CategoryId" },
                values: new object[] { 1, 1, 6 });

            migrationBuilder.InsertData(
                table: "BlogInterests",
                columns: new[] { "Id", "BlogId", "InterestId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "ProjectSkills",
                columns: new[] { "Id", "ProjectId", "SkillId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 1, 2 },
                    { 3, 1, 3 },
                    { 4, 1, 4 },
                    { 5, 1, 5 },
                    { 6, 2, 1 },
                    { 7, 2, 2 },
                    { 8, 2, 3 },
                    { 9, 2, 4 },
                    { 10, 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProjectTechnologies",
                columns: new[] { "Id", "ProjectId", "TechnologyId" },
                values: new object[,]
                {
                    { 1, 1, 3 },
                    { 2, 1, 4 },
                    { 3, 1, 5 },
                    { 4, 1, 6 },
                    { 5, 2, 1 },
                    { 6, 2, 2 },
                    { 7, 2, 3 },
                    { 8, 2, 4 },
                    { 9, 2, 5 },
                    { 10, 2, 7 },
                    { 11, 2, 8 },
                    { 12, 2, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_BlogId",
                table: "BlogCategories",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCategories_CategoryId",
                table: "BlogCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInterests_BlogId",
                table: "BlogInterests",
                column: "BlogId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogInterests_InterestId",
                table: "BlogInterests",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_CategoryId",
                table: "Blogs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_InterestId",
                table: "Blogs",
                column: "InterestId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_SkillId",
                table: "Projects",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TechnologyId",
                table: "Projects",
                column: "TechnologyId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_ProjectId",
                table: "ProjectSkills",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectSkills_SkillId",
                table: "ProjectSkills",
                column: "SkillId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologies_ProjectId",
                table: "ProjectTechnologies",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectTechnologies_TechnologyId",
                table: "ProjectTechnologies",
                column: "TechnologyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogCategories");

            migrationBuilder.DropTable(
                name: "BlogInterests");

            migrationBuilder.DropTable(
                name: "ProjectSkills");

            migrationBuilder.DropTable(
                name: "ProjectTechnologies");

            migrationBuilder.DropTable(
                name: "UserProfiles");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Interests");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "Technologies");
        }
    }
}
