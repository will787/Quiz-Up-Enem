using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuizUpEnem.Data.Migrations
{
    /// <inheritdoc />
    public partial class CreateTableAppQuizENem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppQuizEnems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Materia = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "TEXT", nullable: false),
                    LastUpdateFinished = table.Column<DateTime>(type: "TEXT", nullable: false),
                    User = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppQuizEnems", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppQuizEnems");
        }
    }
}
