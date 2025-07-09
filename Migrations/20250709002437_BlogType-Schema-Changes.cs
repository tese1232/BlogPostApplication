using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlogPostApplication.Migrations
{
    /// <inheritdoc />
    public partial class BlogTypeSchemaChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogTypes",
                table: "BlogTypes");

            migrationBuilder.RenameTable(
                name: "BlogTypes",
                newName: "BlogType");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "BlogType",
                newName: "Status");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BlogType",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BlogType",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogType",
                table: "BlogType",
                column: "BlogTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BlogType",
                table: "BlogType");

            migrationBuilder.RenameTable(
                name: "BlogType",
                newName: "BlogTypes");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "BlogTypes",
                newName: "status");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BlogTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "BlogTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AddPrimaryKey(
                name: "PK_BlogTypes",
                table: "BlogTypes",
                column: "BlogTypeId");
        }
    }
}
