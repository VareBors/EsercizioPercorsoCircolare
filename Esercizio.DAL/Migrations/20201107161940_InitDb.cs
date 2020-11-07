using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Esercizio.DAL.Migrations
{
    public partial class InitDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FigureProfessionali",
                columns: table => new
                {
                    FiguraProfessionaleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descrizione = table.Column<string>(nullable: true),
                    DataCreazione = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FigureProfessionali", x => x.FiguraProfessionaleID);
                });

            migrationBuilder.CreateTable(
                name: "Risorse",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User = table.Column<string>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Cognome = table.Column<string>(nullable: true),
                    DataCreazione = table.Column<DateTime>(nullable: false),
                    FiguraProfessionaleID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Risorse", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Risorse_FigureProfessionali_FiguraProfessionaleID",
                        column: x => x.FiguraProfessionaleID,
                        principalTable: "FigureProfessionali",
                        principalColumn: "FiguraProfessionaleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Risorse_FiguraProfessionaleID",
                table: "Risorse",
                column: "FiguraProfessionaleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Risorse");

            migrationBuilder.DropTable(
                name: "FigureProfessionali");
        }
    }
}
