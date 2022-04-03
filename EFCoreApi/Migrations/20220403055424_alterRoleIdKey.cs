using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApi.Migrations
{
    public partial class alterRoleIdKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
               name: "RoleId",
               table: "Users",
               type: "int",
               nullable: false,
               defaultValue: 3,
               oldNullable: true
               );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
               name: "RoleId",
               table: "Users",
               type: "int",
               nullable: false
               );

        }
    }
}
