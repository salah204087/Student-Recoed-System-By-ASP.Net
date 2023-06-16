using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StudentRecordSystem.Migrations
{
    /// <inheritdoc />
    public partial class AddUnviersityModelAndData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UniversityId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Universities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EstablishmentDate = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Universities", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Universities",
                columns: new[] { "Id", "City", "Description", "EstablishmentDate", "Location", "Name" },
                values: new object[,]
                {
                    { 1, "Giza", "Cairo University (Arabic: جامعة القاهرة, romanized: Jāmi‘a al-Qāhira), also known as the Egyptian University from 1908 to 1940, and King Fuad I University and Fu'ād al-Awwal University from 1940 to 1952, is Egypt's premier public university. Its main campus is in Giza, immediately across the Nile from Cairo. It was founded on 21 December 1908;however, after being housed in various parts of Cairo, its faculties, beginning with the Faculty of Arts, were established on its current main campus in Giza in October 1929. It is the second oldest institution of higher education in Egypt after Al-Azhar University, notwithstanding the pre-existing higher professional schools that later became constituent colleges of the university. It was founded and funded as the Egyptian University by a committee of private citizens with royal patronage in 1908 and became a state institution under King Fuad I in 1925. In 1940, four years following his death, the university was renamed King Fuad I University in his honor. It was renamed a second time after the 1952 Egyptian Revolution. The university currently enrolls approximately 155,000 students in 20 faculties and 3 institutions. It counts three Nobel Laureates among its graduates and is one of the 50 largest institutions of higher education in the world by enrollment.", "December 21, 1908", "1 University Street, Giza 12613", "Cairo Univeristy" },
                    { 2, "Cairo", "Ain Shams University, as the third Egyptian university, was founded in July 1950 under the name of 'Ibrahim Pasha University'. It participated with the two earlier universities, 'Cairo University' (Fua'd the 1st ) and 'Alexandria University' (Farouk the 1st) in fulfilling the message of universities and meeting the increasing demand of youth for higher education. When it was first established, Ain Shams University comprised a number of distinguished faculties and academic institutes, which were later developed into university", "July 1950", "El-Khalyfa El-Mamoun Street Abbasya, Cairo , Eygpt", "Ain Shams University" },
                    { 3, "Helwan", "Helwan University is a member of the Egyptian Supreme Council of Universities. It was established on July 26, 1980 by Act No. 70 of 1975 over 350 acres of land. It is the youngest of 3 major governmental universities in Cairo.However, it goes back to the 19th century during the reign of Muhammad Ali of Egypt who established “The Operations School”. The fields of that school were the basis of many institutes that formed Helwan University later.Although Helwan University is the most recent of 3 major governmental universities in Cairo, it encompasses some of the oldest faculties not only in Egypt but also in the Middle East. The Faculty of Applied Arts, for example, was established in 1839, while the Faculty of Fine Arts and Art Education were established in 1908 and 1936 respectively.", "July 26, 1980", "Al Sikka Al Hadid Al Gharbeya, Qism Helwan", "Helwan University" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Students_UniversityId",
                table: "Students",
                column: "UniversityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students",
                column: "UniversityId",
                principalTable: "Universities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Universities_UniversityId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Universities");

            migrationBuilder.DropIndex(
                name: "IX_Students_UniversityId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "UniversityId",
                table: "Students");

            migrationBuilder.AlterColumn<string>(
                name: "PhoneNumber",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Students",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
