using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FiszkiDataBase.Migrations
{
    /// <inheritdoc />
    public partial class ForView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DictionaryTypeAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dictiona__3214EC07B7D4D22D", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DictionaryTypeContent",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Dictiona__3214EC07F86D7FEA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FicheAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeachSet = table.Column<int>(type: "int", nullable: true),
                    IdFiche = table.Column<int>(type: "int", nullable: true),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true),
                    DateAnswering = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FicheAns__3214EC07EC6B5CEF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "File",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileExtension = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__File__3214EC07ADBF8066", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Password = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__3214EC075668D08A", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SetsFiche",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SetsFich__3214EC0719F640B8", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonOrder",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Fiche",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Response = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Prompt = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TypePrompt = table.Column<int>(type: "int", nullable: true),
                    IdSetFiche = table.Column<int>(type: "int", nullable: true),
                    IdFile = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Fiche__3214EC077185F5EA", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Fiche__IdFile__3C69FB99",
                        column: x => x.IdFile,
                        principalTable: "File",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Fiche__IdSetFich__3B75D760",
                        column: x => x.IdSetFiche,
                        principalTable: "SetsFiche",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Fiche__TypePromp__3A81B327",
                        column: x => x.TypePrompt,
                        principalTable: "DictionaryTypeContent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeachSetsFiche",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdSetFiche = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    FirstTypeAnswer = table.Column<int>(type: "int", nullable: true),
                    LimitTimeSek = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TeachSet__3214EC074AF16EBD", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeachSetFiche",
                        column: x => x.IdSetFiche,
                        principalTable: "SetsFiche",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__TeachSets__First__45F365D3",
                        column: x => x.FirstTypeAnswer,
                        principalTable: "DictionaryTypeAnswer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FicheResponses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdFile = table.Column<int>(type: "int", nullable: true),
                    TypePrompt = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IdFiche = table.Column<int>(type: "int", nullable: true),
                    IsCorect = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FicheRes__3214EC0757D0C7DD", x => x.Id);
                    table.ForeignKey(
                        name: "FK__FicheResp__IdFic__3F466844",
                        column: x => x.IdFiche,
                        principalTable: "Fiche",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__FicheResp__IdFil__3E52440B",
                        column: x => x.IdFile,
                        principalTable: "File",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__FicheResp__TypeP__3D5E1FD2",
                        column: x => x.TypePrompt,
                        principalTable: "DictionaryTypeContent",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FicheTeachState",
                columns: table => new
                {
                    IdFiche = table.Column<int>(type: "int", nullable: false),
                    IdTeachSet = table.Column<int>(type: "int", nullable: false),
                    NumberCorect = table.Column<int>(type: "int", nullable: true),
                    NextTry = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDone = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__FicheTea__6D05EC33244D6B63", x => new { x.IdTeachSet, x.IdFiche });
                    table.ForeignKey(
                        name: "FK__FicheTeac__IdFic__403A8C7D",
                        column: x => x.IdFiche,
                        principalTable: "Fiche",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__FicheTeac__IdTea__412EB0B6",
                        column: x => x.IdTeachSet,
                        principalTable: "TeachSetsFiche",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TeachBags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdTeachSet = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    TypeAnswer = table.Column<int>(type: "int", nullable: true),
                    PeriodTime = table.Column<TimeOnly>(type: "time", nullable: true),
                    LimitTimeSek = table.Column<int>(type: "int", nullable: true),
                    Number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__TeachBag__3214EC07DFE4CDB2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_IdTeachFiche",
                        column: x => x.IdTeachSet,
                        principalTable: "TeachSetsFiche",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TeachBag",
                        column: x => x.TypeAnswer,
                        principalTable: "DictionaryTypeAnswer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fiche_IdFile",
                table: "Fiche",
                column: "IdFile");

            migrationBuilder.CreateIndex(
                name: "IX_Fiche_IdSetFiche",
                table: "Fiche",
                column: "IdSetFiche");

            migrationBuilder.CreateIndex(
                name: "IX_Fiche_TypePrompt",
                table: "Fiche",
                column: "TypePrompt");

            migrationBuilder.CreateIndex(
                name: "IX_FicheResponses_IdFiche",
                table: "FicheResponses",
                column: "IdFiche");

            migrationBuilder.CreateIndex(
                name: "IX_FicheResponses_IdFile",
                table: "FicheResponses",
                column: "IdFile");

            migrationBuilder.CreateIndex(
                name: "IX_FicheResponses_TypePrompt",
                table: "FicheResponses",
                column: "TypePrompt");

            migrationBuilder.CreateIndex(
                name: "IX_FicheTeachState_IdFiche",
                table: "FicheTeachState",
                column: "IdFiche");

            migrationBuilder.CreateIndex(
                name: "IX_SetsFiche_UserId",
                table: "SetsFiche",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TeachBags_IdTeachSet",
                table: "TeachBags",
                column: "IdTeachSet");

            migrationBuilder.CreateIndex(
                name: "IX_TeachBags_TypeAnswer",
                table: "TeachBags",
                column: "TypeAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_TeachSetsFiche_FirstTypeAnswer",
                table: "TeachSetsFiche",
                column: "FirstTypeAnswer");

            migrationBuilder.CreateIndex(
                name: "IX_TeachSetsFiche_IdSetFiche",
                table: "TeachSetsFiche",
                column: "IdSetFiche");

            migrationBuilder.CreateIndex(
                name: "UQ__Users__5E55825B7500623E",
                table: "Users",
                column: "Login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FicheAnswer");

            migrationBuilder.DropTable(
                name: "FicheResponses");

            migrationBuilder.DropTable(
                name: "FicheTeachState");

            migrationBuilder.DropTable(
                name: "TeachBags");

            migrationBuilder.DropTable(
                name: "Fiche");

            migrationBuilder.DropTable(
                name: "TeachSetsFiche");

            migrationBuilder.DropTable(
                name: "File");

            migrationBuilder.DropTable(
                name: "DictionaryTypeContent");

            migrationBuilder.DropTable(
                name: "SetsFiche");

            migrationBuilder.DropTable(
                name: "DictionaryTypeAnswer");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
