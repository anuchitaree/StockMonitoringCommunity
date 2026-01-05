using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMonitoringCommunity.Migrations
{
    /// <inheritdoc />
    public partial class _8_add_master_stock_invisble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Invisible",
                table: "MasterStocks",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Invisible",
                table: "MasterStocks");
        }
    }
}
