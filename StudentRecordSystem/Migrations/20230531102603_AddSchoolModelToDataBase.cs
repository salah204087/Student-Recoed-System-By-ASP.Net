using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentRecordSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddSchoolModelToDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "id", "City", "Location", "Name", "Type" },
                values: new object[,]
                {
                    { 1, "Qaluobia", "15 Damnhor Shobra Elkima ", "Shobra-ElKhima", "Elementary School" },
                    { 2, "Giza", "jazira warraq el-hadr", "El-yosr", "Middle School" },
                    { 3, "Cairo", "shobra street", "El-Tawfikia elthanawya banen", "High School" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Schools");
        }
    }
}
