using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Architecture.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "CourseId", "Description", "Duration", "Name" },
                values: new object[,]
                {
                    { 1, "Year 1, Semester 1. Academic Information Management", "Semester", "AIM101" },
                    { 2, "Year 1, Semester 2. Academic Literacy for IT", "Semester", "ALL121" },
                    { 3, "Year 1. Systems Analysis and Design", "Year", "INF171" },
                    { 4, "Year 2. Systems Analysis and Design", "Year", "INF271" },
                    { 5, "Year 2. Programming", "Year", "INF272" },
                    { 6, "Year 2, Semester 1. Databases", "Semester", "INF214" },
                    { 7, "Year 3, Semester 1. Programming Management", "Semester", "INF315" },
                    { 8, "Year 3, Semester 2. IT Trends", "Semester", "INF324" },
                    { 9, "Year 3, Semester 1. Programming", "Semester", "INF354" },
                    { 10, "Year 3. Project", "Year", "INF370" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");
        }
    }
}
