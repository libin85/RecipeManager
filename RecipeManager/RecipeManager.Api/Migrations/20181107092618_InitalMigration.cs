using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipeManager.Api.Migrations
{
    public partial class InitalMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 750, nullable: false),
                    FoodImage = table.Column<string>(nullable: true),
                    CookingDescription = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Recipes",
                columns: new[] { "Id", "CookingDescription", "FoodImage", "Title" },
                values: new object[,]
                {
                    { new Guid("e28d1220-fd16-4f4b-b33b-494f108d8798"), "tristique nulla aliquet enim tortor at auctor urna nunc id cursus metus aliquam eleifend mi in nulla posuere sollicitudin aliquam ultrices sagittis orci a scelerisque", "", "Mexican street salad" },
                    { new Guid("0d458067-0aa2-4fe3-96b2-18332ec0ace5"), "nisl rhoncus mattis rhoncus urna neque viverra justo nec ultrices dui sapien eget mi proin sed libero enim sed faucibus turpis in eu mi bibendum", "", "Mexican chicken tenders tray bake" },
                    { new Guid("9af1ef0a-2b38-47ca-9244-0de85bf28bf7"), "a scelerisque purus semper eget duis at tellus at urna condimentum mattis pellentesque id nibh tortor id aliquet lectus proin nibh nisl condimentum id venenatis", "", "Sweet and spicy chicken dippers with creamy dipping sauce" },
                    { new Guid("eeb31370-9b51-4990-9d50-ba9924ecb877"), "eu ultrices vitae auctor eu augue ut lectus arcu bibendum at varius vel pharetra vel turpis nunc eget lorem dolor sed viverra ipsum nunc aliquet", "", "Mexican chicken with black bean salsa" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");
        }
    }
}
