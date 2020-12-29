using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RestApiCourceTurorial.Migrations
{
    public partial class PostAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("4e00e4ba-37b1-4c5a-967e-65a70a089422"), "Yuval" });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("ace52839-62ef-4e76-b73d-e5b3a33e063a"), "Antwerp" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
