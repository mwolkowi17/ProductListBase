using Microsoft.EntityFrameworkCore.Migrations;

namespace ProductBase.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyBase",
                columns: table => new
                {
                    ProductDefinitionId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductName = table.Column<string>(nullable: true),
                    ProductDescription = table.Column<string>(nullable: true),
                    YearOfProduction = table.Column<int>(nullable: false),
                    ActualPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyBase", x => x.ProductDefinitionId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MyBase");
        }
    }
}
