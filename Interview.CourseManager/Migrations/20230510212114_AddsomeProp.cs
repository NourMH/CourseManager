using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.CourseManager.Migrations
{
    public partial class AddsomeProp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Academys_AcademyId",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "AcademyId",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AgeFrom",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AgeTo",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "Capacity",
                table: "Courses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Cost",
                table: "Courses",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Academys_AcademyId",
                table: "Courses",
                column: "AcademyId",
                principalTable: "Academys",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Academys_AcademyId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AgeFrom",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "AgeTo",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Capacity",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Courses");

            migrationBuilder.AlterColumn<int>(
                name: "AcademyId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Academys_AcademyId",
                table: "Courses",
                column: "AcademyId",
                principalTable: "Academys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
