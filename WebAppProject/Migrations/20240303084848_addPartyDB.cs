using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppProject.Migrations
{
    /// <inheritdoc />
    public partial class addPartyDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partys",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    img = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Max = table.Column<int>(type: "int", nullable: false)

                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partys", x => x.Name);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partys");
        }
    }
}
