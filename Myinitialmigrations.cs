using Microsoft.EntityFrameworkCore.Migrations;

namespace VehicalApp.Migrations
{
    public partial class Myinitialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VehicInfos",
                columns: table => new
                {
                    VehCategs = table.Column<int>(nullable: false),
                    TypeC = table.Column<int>(nullable: false),
                    Make = table.Column<int>(maxLength: 10, nullable: false),
                    Model = table.Column<string>(nullable: true),
                    Cselect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicInfos", x => x.VehCategs);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VehicInfos");
        }
    }
}
