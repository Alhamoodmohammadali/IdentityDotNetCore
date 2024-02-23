using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement_5.Data.Migrations
{
    public partial class AssignAdminRols : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert into [securety].[UserRoles] (UserId,RoleId)\r\nSelect 'b11a3bdb-c0b8-4e11-8bb6-af358ae17523',id from [securety].[Roles]");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete From  [securety].[UserRoles] where UserId ='b11a3bdb-c0b8-4e11-8bb6-af358ae17523';\r\n");
        }
    }
}
