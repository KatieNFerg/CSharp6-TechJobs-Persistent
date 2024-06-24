using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechJobs6Persistent.Migrations
{
    public partial class AnotherMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobSkills_Jobs_JobsId",
                table: "JobSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_JobSkills_Skills_SkillsId",
                table: "JobSkills");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobSkills",
                table: "JobSkills");

            migrationBuilder.RenameTable(
                name: "JobSkills",
                newName: "JobTags");

            migrationBuilder.RenameIndex(
                name: "IX_JobSkills_SkillsId",
                table: "JobTags",
                newName: "IX_JobTags_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTags",
                table: "JobTags",
                columns: new[] { "JobsId", "SkillsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobTags_Jobs_JobsId",
                table: "JobTags",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobTags_Skills_SkillsId",
                table: "JobTags",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobTags_Jobs_JobsId",
                table: "JobTags");

            migrationBuilder.DropForeignKey(
                name: "FK_JobTags_Skills_SkillsId",
                table: "JobTags");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTags",
                table: "JobTags");

            migrationBuilder.RenameTable(
                name: "JobTags",
                newName: "JobSkills");

            migrationBuilder.RenameIndex(
                name: "IX_JobTags_SkillsId",
                table: "JobSkills",
                newName: "IX_JobSkills_SkillsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobSkills",
                table: "JobSkills",
                columns: new[] { "JobsId", "SkillsId" });

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkills_Jobs_JobsId",
                table: "JobSkills",
                column: "JobsId",
                principalTable: "Jobs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JobSkills_Skills_SkillsId",
                table: "JobSkills",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
