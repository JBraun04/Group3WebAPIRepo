using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Group3WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class Hobby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
    name: "Hobby",
    columns: table => new
    {
        Id = table.Column<int>(type: "int", nullable: false)
            .Annotation("SqlServer:Identity", "1, 1"),
        hobbyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
        hobbyDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
        avgProjCost = table.Column<float>(type: "real", nullable: false),
        hoursPerWeek = table.Column<int>(type: "int", nullable: false)
    },
    constraints: table =>
    {
        table.PrimaryKey("PK_Hobby", x => x.Id);
    });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
    name: "Hobby");
        }
    }
}
