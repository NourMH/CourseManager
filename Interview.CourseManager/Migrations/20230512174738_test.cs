using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Interview.CourseManager.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseBranch_ClubBranches_ClubBranchId",
                table: "CourseBranch");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseBranch_Courses_CourseId",
                table: "CourseBranch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseBranch",
                table: "CourseBranch");

            migrationBuilder.RenameTable(
                name: "CourseBranch",
                newName: "CourseBranchs");

            migrationBuilder.RenameIndex(
                name: "IX_CourseBranch_CourseId",
                table: "CourseBranchs",
                newName: "IX_CourseBranchs_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseBranch_ClubBranchId",
                table: "CourseBranchs",
                newName: "IX_CourseBranchs_ClubBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseBranchs",
                table: "CourseBranchs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseBranchs_ClubBranches_ClubBranchId",
                table: "CourseBranchs",
                column: "ClubBranchId",
                principalTable: "ClubBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseBranchs_Courses_CourseId",
                table: "CourseBranchs",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseBranchs_ClubBranches_ClubBranchId",
                table: "CourseBranchs");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseBranchs_Courses_CourseId",
                table: "CourseBranchs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseBranchs",
                table: "CourseBranchs");

            migrationBuilder.RenameTable(
                name: "CourseBranchs",
                newName: "CourseBranch");

            migrationBuilder.RenameIndex(
                name: "IX_CourseBranchs_CourseId",
                table: "CourseBranch",
                newName: "IX_CourseBranch_CourseId");

            migrationBuilder.RenameIndex(
                name: "IX_CourseBranchs_ClubBranchId",
                table: "CourseBranch",
                newName: "IX_CourseBranch_ClubBranchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseBranch",
                table: "CourseBranch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseBranch_ClubBranches_ClubBranchId",
                table: "CourseBranch",
                column: "ClubBranchId",
                principalTable: "ClubBranches",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseBranch_Courses_CourseId",
                table: "CourseBranch",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
