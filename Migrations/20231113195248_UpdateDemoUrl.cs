using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDemoUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Demo",
                value: "https://www.loom.com/share/8cefd393719347a28ee318e221b7b386?sid=66e4151a-88a6-4779-97f5-70e15744e175");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Demo",
                value: "https://www.loom.com/share/8cefd393719347a28ee318e221b7b386?sid=2e2266bf-d7fb-4a43-b227-3df54e75e4e2");
        }
    }
}
