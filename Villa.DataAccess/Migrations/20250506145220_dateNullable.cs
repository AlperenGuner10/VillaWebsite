using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Villa.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dateNullable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "MessageDate",
                table: "Messages",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageDate",
                table: "Messages");
        }
    }
}
