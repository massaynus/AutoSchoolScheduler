using Microsoft.EntityFrameworkCore.Migrations;

namespace Scheduler.Migrations
{
    public partial class RemovedPersonTypesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_PersonTypes_TypeID",
                table: "People");

            migrationBuilder.DropTable(
                name: "PersonTypes");

            migrationBuilder.DropIndex(
                name: "IX_People_TypeID",
                table: "People");

            migrationBuilder.DropColumn(
                name: "TypeID",
                table: "People");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeID",
                table: "People",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    PTID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.PTID);
                });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "PTID", "Name" },
                values: new object[] { 1, "Teacher" });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "PTID", "Name" },
                values: new object[] { 2, "Student" });

            migrationBuilder.CreateIndex(
                name: "IX_People_TypeID",
                table: "People",
                column: "TypeID");

            migrationBuilder.AddForeignKey(
                name: "FK_People_PersonTypes_TypeID",
                table: "People",
                column: "TypeID",
                principalTable: "PersonTypes",
                principalColumn: "PTID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
