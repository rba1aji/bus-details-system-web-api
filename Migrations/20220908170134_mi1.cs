using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace BusDetailsSystem.Migrations
{
    public partial class mi1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BusDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Origin = table.Column<string>(type: "text", nullable: false),
                    Destination = table.Column<string>(type: "text", nullable: false),
                    Votes = table.Column<int>(type: "integer", nullable: false),
                    BusOwner = table.Column<string>(type: "text", nullable: false),
                    BusNo = table.Column<string>(type: "text", nullable: true),
                    BusName = table.Column<string>(type: "text", nullable: true),
                    OriginTime = table.Column<string>(type: "text", nullable: true),
                    DestinationTime = table.Column<string>(type: "text", nullable: true),
                    AuthorName = table.Column<string>(type: "text", nullable: false),
                    PostDate = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusDetails", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusDetails");
        }
    }
}
