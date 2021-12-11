using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SacramentPlan",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    conductingLeader = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    openingSong = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    sacramentHymn = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    closingSong = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    specialMusicalNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    specialMusicalNumberName = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    firstSpeaker = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    firstSpeakerSubject = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    secondSpeaker = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    secondSpeakerSubject = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    thirdSpeaker = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    thirdSpeakerSubject = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SacramentPlan", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SacramentPlan");
        }
    }
}
