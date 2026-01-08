using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace StockMonitoringCommunity.Migrations
{
    /// <inheritdoc />
    public partial class _11_server_connection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ServerConnections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ServerAddress = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Port = table.Column<int>(type: "integer", nullable: false),
                    StoreID = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    SourcePCID = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServerConnections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stores",
                columns: table => new
                {
                    Store_Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StoreID = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    StoreName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    StoreLocation = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stores", x => x.Store_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ServerConnections");

            migrationBuilder.DropTable(
                name: "Stores");
        }
    }
}
