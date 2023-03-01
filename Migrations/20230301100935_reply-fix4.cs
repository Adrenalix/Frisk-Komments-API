using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Frisk_API.Migrations
{
    public partial class replyfix4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn("CommentId", "Comments", "ReplyId");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
