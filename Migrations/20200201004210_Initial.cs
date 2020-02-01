using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelterAPI.Solution.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                });

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "Description", "Gender", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 7, "Freindly cat that loves getting pet", "Female", "Matilda", "Cat" },
                    { 2, 10, "A cat with a personaility, and she will let you know how she is feeling", "Female", "Rexie", "Cat" },
                    { 3, 2, "Friendly dog that lives to cuddle and hang out with people", "Female", "Matilda", "Dog" },
                    { 4, 4, "A ball of energy who loves to play anytime possible", "Male", "Pip", "Dog" },
                    { 5, 12, "Was found on the streets, shy at first but once he warms up with you he'll never leave your side", "Male", "Bartholomew", "Dog" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
