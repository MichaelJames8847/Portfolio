using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Migrations
{
    /// <inheritdoc />
    public partial class BlogImageAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://res.cloudinary.com/practicaldev/image/fetch/s--VjOTp9uS--/c_imagga_scale,f_auto,fl_progressive,h_420,q_auto,w_1000/https://dev-to-uploads.s3.amazonaws.com/i/2o2t0fyzszqheinl9x7a.png");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "null");
        }
    }
}
