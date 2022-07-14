using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Acme.StudentManage.Migrations
{
    public partial class phase2_addTable_Student : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mssv",
                schema: "common",
                table: "AppSinhViens",
                newName: "CMND");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CMND",
                schema: "common",
                table: "AppSinhViens",
                newName: "mssv");
        }
    }
}
