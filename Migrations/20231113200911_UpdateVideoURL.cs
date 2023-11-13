using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class UpdateVideoURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Demo",
                value: "https://www.loom.com/share/8cefd393719347a28ee318e221b7b386?sid=62c590e0-9780-4a9d-9428-d1226f855005");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                column: "Demo",
                value: "https://www.loom.com/share/8cefd393719347a28ee318e221b7b386?sid=66e4151a-88a6-4779-97f5-70e15744e175");
        }
    }
}
