using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentRecordSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddFacultyModelToDataBaseAndAddDataOnIt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Faculties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculties", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Faculty of Engineering" },
                    { 2, "Faculty of Medicine" },
                    { 3, "Faculty of Computers and Artificial Intelligence" },
                    { 4, "Faculty of Pharmacy" },
                    { 5, "Faculty of Agriculture " },
                    { 6, "Faculty of Science" },
                    { 7, "Faculty of Economics and Political Science" },
                    { 8, "Faculty of Mass Communication" },
                    { 9, "Faculty of Archaeology " },
                    { 10, "Faculty of Arts" },
                    { 11, "Faculty of Commerce" },
                    { 12, "Faculty of Specific Education" },
                    { 13, "Faculty of Nursing" },
                    { 14, "Faculty of Law" },
                    { 15, "Faculty of Physical Therapy" },
                    { 16, "Faculty of Oral and Dental Medicine" },
                    { 17, "Faculty of Dar El-Ulum" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faculties");
        }
    }
}
