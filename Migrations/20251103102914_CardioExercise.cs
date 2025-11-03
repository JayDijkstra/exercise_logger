using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExerciseLogger.Migrations
{
    /// <inheritdoc />
    public partial class CardioExercise : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DurationInMinutes",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DurationInMinutes",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "Level",
                table: "Exercises");
        }
    }
}
