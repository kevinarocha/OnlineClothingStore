using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineClothingStore.Migrations
{
    /// <inheritdoc />
    public partial class firstM : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Item",
                type: "character varying(350)",
                maxLength: 350,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Item");
        }
    }
}
