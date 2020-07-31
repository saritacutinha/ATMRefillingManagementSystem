using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ATMRefillingManagementSystem.Migrations
{
    public partial class CreateTableRefills : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Refills",
                columns: table => new
                {
                    RefillID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KeyQualifier = table.Column<string>(nullable: true, defaultValue: "RID"),
                    BankID = table.Column<int>(nullable: false),
                    Area = table.Column<string>(nullable: true),
                    Amount = table.Column<int>(nullable: false),
                    RefillDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refills", x => x.RefillID);
                    table.ForeignKey(
                        name: "FK_Refills_Banks_BankID",
                        column: x => x.BankID,
                        principalTable: "Banks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Refills_BankID",
                table: "Refills",
                column: "BankID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Refills");
        }
    }
}
