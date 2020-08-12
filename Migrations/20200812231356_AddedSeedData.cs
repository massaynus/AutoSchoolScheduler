using Microsoft.EntityFrameworkCore.Migrations;

namespace Scheduler.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "PTID", "Name" },
                values: new object[] { 1, "Teacher" });

            migrationBuilder.InsertData(
                table: "PersonTypes",
                columns: new[] { "PTID", "Name" },
                values: new object[] { 2, "Student" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonTypes",
                keyColumn: "PTID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PersonTypes",
                keyColumn: "PTID",
                keyValue: 2);
        }
    }
}
