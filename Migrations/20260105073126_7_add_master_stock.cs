using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StockMonitoringCommunity.Migrations
{
    /// <inheritdoc />
    public partial class _7_add_master_stock : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccumulateStockLogs",
                columns: table => new
                {
                    AccumulateStockLog_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Partnumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccumulateStockLogs", x => x.AccumulateStockLog_ID);
                });

            migrationBuilder.CreateTable(
                name: "MasterStocks",
                columns: table => new
                {
                    Stock_ID = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Partnumber = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Location = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    Balance = table.Column<int>(type: "integer", nullable: false),
                    UpperLimit = table.Column<int>(type: "integer", nullable: false),
                    UpperWarningLimit = table.Column<int>(type: "integer", nullable: false),
                    LowerWarningLimit = table.Column<int>(type: "integer", nullable: false),
                    LowerLimit = table.Column<int>(type: "integer", nullable: false),
                    CreatedAt = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MasterStocks", x => x.Stock_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccumulateStockLogs");

            migrationBuilder.DropTable(
                name: "MasterStocks");
        }
    }
}
