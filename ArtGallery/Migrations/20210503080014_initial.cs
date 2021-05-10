using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArtGallery.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArtModels",
                columns: table => new
                {
                    ArtModelId = table.Column<double>(type: "float", nullable: false),
                    FID = table.Column<double>(type: "float", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Source_ID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Artist = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Medium = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtForm = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThumbURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageAltText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LONG = table.Column<double>(type: "float", nullable: false),
                    LAT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WARD = table.Column<double>(type: "float", nullable: false),
                    WARD_FULLNAME = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    YEAR_INSTALLED = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OwnedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommissionedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PublicArtConsultant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageOrientation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExternalLinkText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FID2 = table.Column<double>(type: "float", nullable: false),
                    geometry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtModels", x => x.ArtModelId);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Post = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArtModelId = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_ArtModels_ArtModelId",
                        column: x => x.ArtModelId,
                        principalTable: "ArtModels",
                        principalColumn: "ArtModelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArtModelId",
                table: "Comments",
                column: "ArtModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "ArtModels");
        }
    }
}
