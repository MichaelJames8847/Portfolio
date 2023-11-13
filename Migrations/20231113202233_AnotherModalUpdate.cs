using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class AnotherModalUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Demo",
                value: "https://www.loom.com/embed/8cefd393719347a28ee318e221b7b386?sid=fb253bdd-f47f-4078-8945-9e2ded4870f8");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Demo",
                value: "https://www.loom.com/share/8cefd393719347a28ee318e221b7b386?sid=62c590e0-9780-4a9d-9428-d1226f855005");
        }
    }
}
