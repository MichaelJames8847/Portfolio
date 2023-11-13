using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class AddBlogPost : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CategoryId", "Content", "Image", "InterestId", "PostDate", "Title" },
                values: new object[] { 2, null, "Welcome to another chapter of my journey where I blend the worlds of software engineering and creative arts. \r\n            In this blog post, I dive into how my passions for music, gaming, and fitness not only shape my personal life but also enhance my professional skills as a software engineer.\r\n\r\n            The Rhythmic Patterns of Programming\r\n\r\n            In the realm of coding, I find a unique rhythm that resonates with my musical side. The process of writing code, much like composing a piece of music, requires a deep understanding of \r\n            patterns, rhythms, and structures. Each line of code, like a musical note, plays a critical role in the composition of software. This analogy often guides my approach to problem-solving \r\n            and designing solutions. The fluidity and creativity I harness from music empower me to write more elegant and efficient code.\r\n\r\n            Gaming: A Portal to Advanced Problem-Solving\r\n\r\n            Gaming is not just a leisure activity for me; it's a gateway to complex problem-solving and strategic thinking. Immersing in game narratives and mechanics, I draw parallels \r\n            with software design, especially in user experience (UX) and user interface (UI) aspects. Understanding how games engage users helps me envision software applications that are \r\n            not only functional but also enjoyable to use.\r\n\r\n            Fitness: Strengthening the Mind-Body Connection\r\n\r\n            Physical fitness plays a pivotal role in maintaining my mental agility. Regular exercise helps in decluttering my mind, often leading to moments of clarity and inspiration. \r\n            The discipline and endurance I gain from fitness activities translate into my work ethic as a developer, enabling me to tackle challenging coding sessions and tight project deadlines.\r\n\r\n            Blending Interests: The Bigger Picture\r\n\r\n            My journey in software engineering is heavily influenced by my interests outside of programming. Each interest adds a unique flavor to my professional skill set. \r\n            Whether it's the creativity from music, strategic thinking from gaming, or discipline from fitness, they collectively contribute to making me a well-rounded software engineer.\r\n\r\n            Looking Forward\r\n\r\n            As I continue to explore and grow in this field, I look forward to sharing insights and experiences that meld these diverse worlds. \r\n            From dissecting the latest web development trends to tackling new challenges in database design, I will document my learnings and adventures here.\r\n\r\n            Join me as I navigate the intricate tapestry of software engineering, infused with the vibrancy of my personal passions. Here's to coding not just with logic, but with creativity and heart!", "https://i.redd.it/5zrpk77yach41.jpg", null, new DateTime(2023, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Harmony of Code and Creativity: My Software Engineering Symphony" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
