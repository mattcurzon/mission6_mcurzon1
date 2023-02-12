using Microsoft.EntityFrameworkCore.Migrations;

namespace mission6_mcurzon1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: true),
                    Rating = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Rating", "Title", "Year" },
                values: new object[] { 1, "Drama", "Richard Linklater", "R", "Before Sunrise", (ushort)1995 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Rating", "Title", "Year" },
                values: new object[] { 2, "Drama", "Richard Linklater", "R", "Before Sunset", (ushort)2004 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieID", "Category", "Director", "Rating", "Title", "Year" },
                values: new object[] { 3, "Crime/Drama", "Quentin Tarantino", "R", "Pulp Fiction", (ushort)1994 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
