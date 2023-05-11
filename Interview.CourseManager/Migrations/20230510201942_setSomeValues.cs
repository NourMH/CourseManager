using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.CourseManager.Migrations
{
    public partial class setSomeValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Academys",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Academy1" },
                    { 2, "Academy2" }
                });

            migrationBuilder.InsertData(
                table: "SportTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "SportType1" },
                    { 2, "SportType2" }
                });

            migrationBuilder.InsertData(
                table: "Staduims",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Staduim1" },
                    { 2, "Staduim2" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Academys",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Academys",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SportTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SportTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Staduims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Staduims",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
