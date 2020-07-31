using Microsoft.EntityFrameworkCore.Migrations;

namespace ATMRefillingManagementSystem.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Banks (Name) VALUES ('ICICI Bank')");
            migrationBuilder.Sql("INSERT INTO Banks (Name) VALUES ('HDFC Bank')");
            migrationBuilder.Sql("INSERT INTO Banks (Name) VALUES ('AXIS Bank')");
            migrationBuilder.Sql("INSERT INTO Banks (Name) VALUES ('SBI Bank')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Banks");
        }
    }
}
