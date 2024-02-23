using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement_5.Data.Migrations
{

    public partial class AddAdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("  INSERT INTO [securety].[Users] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [FirstName], [ImageBinary], [SecoundName]) VALUES (N'b11a3bdb-c0b8-4e11-8bb6-af358ae17523', N'Admin', N'ADMIN', N'Admin@gmail.com', N'ADMIN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEN0E6GebnN8bz+0H8yfc64ac10sRo7Mxsjrj4Nqn2IqqY6wIOPRJ4cLKW6B8tJ/YQQ==', N'4PPTJG7QFDKQ7IIXWP5N63SUXJ5E4GIW', N'565a571b-bf18-41c3-afb4-9a2a34de3a0a', NULL, 0, 0, NULL, 1, 0, N'Mohammad1234', NULL, N'ALihamoo')\r\n");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM [securety].[Users] Where id = 'b11a3bdb-c0b8-4e11-8bb6-af358ae17523' ");
        }
    }
}
