using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MediPlus_DAL.Migrations
{
    /// <inheritdoc />
    public partial class lsjuu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImgPath",
                table: "SliderItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImgPath",
                table: "SliderItems");
        }
    }
}
