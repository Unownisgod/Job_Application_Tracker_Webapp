using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Job_Application_Tracker_Webapp.Migrations
{
    public partial class Application : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Application",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    enterprise = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    confidence = table.Column<short>(type: "smallint", nullable: false),
                    link = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    application_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state_change_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    user_id = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Application", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Application");
        }
    }
}
