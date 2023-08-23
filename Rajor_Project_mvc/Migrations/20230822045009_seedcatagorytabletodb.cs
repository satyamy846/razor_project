using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Rajor_Project_mvc.Migrations
{
    /// <inheritdoc />
    public partial class seedcatagorytabletodb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Catagories",
                columns: new[] { "Id", "DisplayOrder", "Name" },
                values: new object[] { 1, 2, "Satyam" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Catagories",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
