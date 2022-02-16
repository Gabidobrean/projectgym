using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace project.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Antrenor",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NumeAntrenor = table.Column<string>(nullable: true),
                    PrenumeAntrenor = table.Column<string>(nullable: true),
                    Ziua = table.Column<string>(nullable: true),
                    Ora = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Antrenor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Curs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DenumireCurs = table.Column<string>(nullable: true),
                    Dificultate = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Curs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Abonament",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tip = table.Column<string>(maxLength: 50, nullable: false),
                    Pret = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    DataCreareAbonament = table.Column<DateTime>(nullable: false),
                    AntrenorID = table.Column<int>(nullable: false),
                    CursID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abonament", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Abonament_Antrenor_AntrenorID",
                        column: x => x.AntrenorID,
                        principalTable: "Antrenor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Abonament_Curs_CursID",
                        column: x => x.CursID,
                        principalTable: "Curs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abonament_AntrenorID",
                table: "Abonament",
                column: "AntrenorID");

            migrationBuilder.CreateIndex(
                name: "IX_Abonament_CursID",
                table: "Abonament",
                column: "CursID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abonament");

            migrationBuilder.DropTable(
                name: "Antrenor");

            migrationBuilder.DropTable(
                name: "Curs");
        }
    }
}
