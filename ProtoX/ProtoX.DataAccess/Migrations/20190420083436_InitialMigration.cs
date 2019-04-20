using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProtoX.DataAccess.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "ProtoX");

            migrationBuilder.CreateTable(
                name: "Categories",
                schema: "ProtoX",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "ProtoX",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Description = table.Column<string>(nullable: false),
                    Image = table.Column<byte[]>(nullable: true),
                    BidStartTime = table.Column<DateTime>(nullable: true),
                    BidEndTime = table.Column<DateTime>(nullable: true),
                    InitialBidPrice = table.Column<float>(nullable: false),
                    CurrentBidPrice = table.Column<float>(nullable: false),
                    PreviousBidPrice = table.Column<float>(nullable: false),
                    Location = table.Column<string>(nullable: false),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                schema: "ProtoX",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(maxLength: 200, nullable: true),
                    LastName = table.Column<string>(maxLength: 200, nullable: true),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(maxLength: 254, nullable: false),
                    City = table.Column<string>(maxLength: 189, nullable: true),
                    Country = table.Column<string>(maxLength: 90, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategoryMappings",
                schema: "ProtoX",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategoryMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCategoryMappings_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "ProtoX",
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductCategoryMappings_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ProtoX",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductUserMappings",
                schema: "ProtoX",
                columns: table => new
                {
                    CreatedOn = table.Column<DateTime>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    UserInformationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUserMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductUserMappings_Products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "ProtoX",
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductUserMappings_UserInformation_UserInformationId",
                        column: x => x.UserInformationId,
                        principalSchema: "ProtoX",
                        principalTable: "UserInformation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryMappings_CategoryId",
                schema: "ProtoX",
                table: "ProductCategoryMappings",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategoryMappings_ProductId",
                schema: "ProtoX",
                table: "ProductCategoryMappings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUserMappings_ProductId",
                schema: "ProtoX",
                table: "ProductUserMappings",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUserMappings_UserInformationId",
                schema: "ProtoX",
                table: "ProductUserMappings",
                column: "UserInformationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductCategoryMappings",
                schema: "ProtoX");

            migrationBuilder.DropTable(
                name: "ProductUserMappings",
                schema: "ProtoX");

            migrationBuilder.DropTable(
                name: "Categories",
                schema: "ProtoX");

            migrationBuilder.DropTable(
                name: "Products",
                schema: "ProtoX");

            migrationBuilder.DropTable(
                name: "UserInformation",
                schema: "ProtoX");
        }
    }
}
