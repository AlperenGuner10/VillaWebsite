using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class featureEntityPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Payment",
                table: "Features",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment",
                table: "Features");
        }
    }
}
