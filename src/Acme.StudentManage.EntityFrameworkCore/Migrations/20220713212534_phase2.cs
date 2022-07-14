using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.StudentManage.Migrations
{
    public partial class phase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSinhViens_AppLops_LopID",
                schema: "common",
                table: "AppSinhViens");

            migrationBuilder.RenameColumn(
                name: "LopID",
                schema: "common",
                table: "AppSinhViens",
                newName: "lopID");

            migrationBuilder.RenameIndex(
                name: "IX_AppSinhViens_LopID",
                schema: "common",
                table: "AppSinhViens",
                newName: "IX_AppSinhViens_lopID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSinhViens_AppLops_lopID",
                schema: "common",
                table: "AppSinhViens",
                column: "lopID",
                principalSchema: "common",
                principalTable: "AppLops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppSinhViens_AppLops_lopID",
                schema: "common",
                table: "AppSinhViens");

            migrationBuilder.RenameColumn(
                name: "lopID",
                schema: "common",
                table: "AppSinhViens",
                newName: "LopID");

            migrationBuilder.RenameIndex(
                name: "IX_AppSinhViens_lopID",
                schema: "common",
                table: "AppSinhViens",
                newName: "IX_AppSinhViens_LopID");

            migrationBuilder.AddForeignKey(
                name: "FK_AppSinhViens_AppLops_LopID",
                schema: "common",
                table: "AppSinhViens",
                column: "LopID",
                principalSchema: "common",
                principalTable: "AppLops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
