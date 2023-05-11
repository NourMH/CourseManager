using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.CourseManager.Migrations
{
    public partial class relationCourseReserve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staduims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staduims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AcademyId = table.Column<int>(type: "int", nullable: false),
                    StaduimId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Academys_AcademyId",
                        column: x => x.AcademyId,
                        principalTable: "Academys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Courses_Staduims_StaduimId",
                        column: x => x.StaduimId,
                        principalTable: "Staduims",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseBranch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    ClubBranchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseBranch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseBranch_ClubBranches_ClubBranchId",
                        column: x => x.ClubBranchId,
                        principalTable: "ClubBranches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseBranch_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseReservations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseReservations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseReservations_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseBranch_ClubBranchId",
                table: "CourseBranch",
                column: "ClubBranchId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseBranch_CourseId",
                table: "CourseBranch",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseReservations_CourseId",
                table: "CourseReservations",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_AcademyId",
                table: "Courses",
                column: "AcademyId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_StaduimId",
                table: "Courses",
                column: "StaduimId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseBranch");

            migrationBuilder.DropTable(
                name: "CourseReservations");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Staduims");
        }
    }
}
