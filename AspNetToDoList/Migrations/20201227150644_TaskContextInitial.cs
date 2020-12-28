using Microsoft.EntityFrameworkCore.Migrations;

namespace AspNetToDoList.Migrations
{
    public partial class TaskContextInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TaskSchema",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    title = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 200, nullable: true),
                    Status = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskSchema", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TaskSchema",
                columns: new[] { "Id", "Description", "Status", "title" },
                values: new object[] { 1, "The one with that big park.", false, "New York City" });

            migrationBuilder.InsertData(
                table: "TaskSchema",
                columns: new[] { "Id", "Description", "Status", "title" },
                values: new object[] { 2, "The one with the cathedral that was never really finished.", false, "Antwerp" });

            migrationBuilder.InsertData(
                table: "TaskSchema",
                columns: new[] { "Id", "Description", "Status", "title" },
                values: new object[] { 3, "The one with that big tower.", false, "Paris" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TaskSchema");
        }
    }
}
