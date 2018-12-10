using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace dngit.Data.Migrations
{
    public partial class changeddatastructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingValues_Ratings_RatingId",
                table: "RatingValues");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.RenameColumn(
                name: "RatingId",
                table: "RatingValues",
                newName: "PlaceId");

            migrationBuilder.RenameIndex(
                name: "IX_RatingValues_RatingId",
                table: "RatingValues",
                newName: "IX_RatingValues_PlaceId");

            migrationBuilder.AddColumn<double>(
                name: "OverAllRating",
                table: "Places",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_RatingValues_Places_PlaceId",
                table: "RatingValues",
                column: "PlaceId",
                principalTable: "Places",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RatingValues_Places_PlaceId",
                table: "RatingValues");

            migrationBuilder.DropColumn(
                name: "OverAllRating",
                table: "Places");

            migrationBuilder.RenameColumn(
                name: "PlaceId",
                table: "RatingValues",
                newName: "RatingId");

            migrationBuilder.RenameIndex(
                name: "IX_RatingValues_PlaceId",
                table: "RatingValues",
                newName: "IX_RatingValues_RatingId");

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    OverAllRating = table.Column<double>(nullable: false),
                    PlaceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ratings_Places_PlaceId",
                        column: x => x.PlaceId,
                        principalTable: "Places",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PlaceId",
                table: "Ratings",
                column: "PlaceId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_RatingValues_Ratings_RatingId",
                table: "RatingValues",
                column: "RatingId",
                principalTable: "Ratings",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
