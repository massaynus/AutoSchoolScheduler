using Microsoft.EntityFrameworkCore.Migrations;

namespace Scheduler.Migrations
{
    public partial class NullForeignKeys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_PersonTypes_TypeID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Groupes_GroupeID",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "TypeID",
                table: "People",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_People_PersonTypes_TypeID",
                table: "People",
                column: "TypeID",
                principalTable: "PersonTypes",
                principalColumn: "PTID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Groupes_GroupeID",
                table: "People",
                column: "GroupeID",
                principalTable: "Groupes",
                principalColumn: "GroupeID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_People_PersonTypes_TypeID",
                table: "People");

            migrationBuilder.DropForeignKey(
                name: "FK_People_Groupes_GroupeID",
                table: "People");

            migrationBuilder.AlterColumn<int>(
                name: "TypeID",
                table: "People",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_People_PersonTypes_TypeID",
                table: "People",
                column: "TypeID",
                principalTable: "PersonTypes",
                principalColumn: "PTID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_People_Groupes_GroupeID",
                table: "People",
                column: "GroupeID",
                principalTable: "Groupes",
                principalColumn: "GroupeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
