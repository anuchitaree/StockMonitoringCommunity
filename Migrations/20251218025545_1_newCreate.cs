using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMonitoringCommunity.Migrations
{
    /// <inheritdoc />
    public partial class _1_newCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comports",
                columns: table => new
                {
                    Channel_ID = table.Column<int>(type: "integer", nullable: false),
                    PortName = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Baudrate = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Parity = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DataBits = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Stopbit = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Direction = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Handshake = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Pattern1 = table.Column<int>(type: "integer", nullable: false),
                    Pattern2 = table.Column<int>(type: "integer", nullable: false),
                    Pattern3 = table.Column<int>(type: "integer", nullable: false),
                    Pattern4 = table.Column<int>(type: "integer", nullable: false),
                    Pattern5 = table.Column<int>(type: "integer", nullable: false),
                    Pattern6 = table.Column<int>(type: "integer", nullable: false),
                    Lastedit = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Enable = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comports", x => x.Channel_ID);
                });

            migrationBuilder.CreateTable(
                name: "InputPatterns",
                columns: table => new
                {
                    Pattern_ID = table.Column<int>(type: "integer", nullable: false),
                    TotalOfCharactor = table.Column<int>(type: "integer", nullable: false),
                    StartCharactor = table.Column<int>(type: "integer", nullable: false),
                    NumberOfCharactor = table.Column<int>(type: "integer", nullable: false),
                    Result = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    ExampleText = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    UniqueStart = table.Column<int>(type: "integer", nullable: false),
                    UniqueText = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InputPatterns", x => x.Pattern_ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comports");

            migrationBuilder.DropTable(
                name: "InputPatterns");
        }
    }
}
