using Microsoft.EntityFrameworkCore.Migrations;

namespace Scheduler.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BrancheID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrancheName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BrancheID);
                });

            migrationBuilder.CreateTable(
                name: "ClassRooms",
                columns: table => new
                {
                    RoomID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRooms", x => x.RoomID);
                });

            migrationBuilder.CreateTable(
                name: "Equipements",
                columns: table => new
                {
                    EquipementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Count = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipements", x => x.EquipementID);
                });

            migrationBuilder.CreateTable(
                name: "Groupes",
                columns: table => new
                {
                    GroupeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groupes", x => x.GroupeID);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    ModuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleName = table.Column<string>(nullable: true),
                    Length = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.ModuleID);
                });

            migrationBuilder.CreateTable(
                name: "PersonTypes",
                columns: table => new
                {
                    PTID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTypes", x => x.PTID);
                });

            migrationBuilder.CreateTable(
                name: "ClassRoomEquipements",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoomID = table.Column<int>(nullable: false),
                    EquipementID = table.Column<int>(nullable: false),
                    UsedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoomEquipements", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ClassRoomEquipements_Equipements_EquipementID",
                        column: x => x.EquipementID,
                        principalTable: "Equipements",
                        principalColumn: "EquipementID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ClassRoomEquipements_ClassRooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "ClassRooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BrancheModules",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleID = table.Column<int>(nullable: false),
                    BrancheID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrancheModules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BrancheModules_Branches_BrancheID",
                        column: x => x.BrancheID,
                        principalTable: "Branches",
                        principalColumn: "BrancheID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrancheModules_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CIN = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Adresse = table.Column<string>(nullable: true),
                    GSM = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    TypeID = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    ParentGSM = table.Column<string>(nullable: true),
                    Matricule = table.Column<string>(nullable: true),
                    GroupeID = table.Column<int>(nullable: true),
                    RIB = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.ID);
                    table.ForeignKey(
                        name: "FK_People_PersonTypes_TypeID",
                        column: x => x.TypeID,
                        principalTable: "PersonTypes",
                        principalColumn: "PTID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_People_Groupes_GroupeID",
                        column: x => x.GroupeID,
                        principalTable: "Groupes",
                        principalColumn: "GroupeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherModules",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherID = table.Column<int>(nullable: false),
                    ModuleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherModules", x => x.ID);
                    table.ForeignKey(
                        name: "FK_TeacherModules_Modules_ModuleID",
                        column: x => x.ModuleID,
                        principalTable: "Modules",
                        principalColumn: "ModuleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherModules_People_TeacherID",
                        column: x => x.TeacherID,
                        principalTable: "People",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrancheModules_BrancheID",
                table: "BrancheModules",
                column: "BrancheID");

            migrationBuilder.CreateIndex(
                name: "IX_BrancheModules_ModuleID",
                table: "BrancheModules",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoomEquipements_EquipementID",
                table: "ClassRoomEquipements",
                column: "EquipementID");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoomEquipements_RoomID",
                table: "ClassRoomEquipements",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_People_TypeID",
                table: "People",
                column: "TypeID");

            migrationBuilder.CreateIndex(
                name: "IX_People_GroupeID",
                table: "People",
                column: "GroupeID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherModules_ModuleID",
                table: "TeacherModules",
                column: "ModuleID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherModules_TeacherID",
                table: "TeacherModules",
                column: "TeacherID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrancheModules");

            migrationBuilder.DropTable(
                name: "ClassRoomEquipements");

            migrationBuilder.DropTable(
                name: "TeacherModules");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Equipements");

            migrationBuilder.DropTable(
                name: "ClassRooms");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "PersonTypes");

            migrationBuilder.DropTable(
                name: "Groupes");
        }
    }
}
