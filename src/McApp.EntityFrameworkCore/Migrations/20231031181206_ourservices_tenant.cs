using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace McApp.Migrations
{
    /// <inheritdoc />
    public partial class ourservicestenant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "TenantId",
                table: "OurServiceItems",
                type: "uniqueidentifier",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TenantId",
                table: "OurServiceItems");
        }
    }
}
