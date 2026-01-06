using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockMonitoringCommunity.Migrations
{
    /// <inheritdoc />
    public partial class _10_modify_Id_name : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "ScanInOutTransactions",
                newName: "ScanInOutTransaction_Id");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Packagings",
                newName: "Packaging_Id");

            migrationBuilder.RenameColumn(
                name: "Stock_ID",
                table: "MasterStocks",
                newName: "MasterStock_Id");

            migrationBuilder.AddColumn<string>(
                name: "StoreId",
                table: "ScanInOutTransactions",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "StoreID",
                table: "Packagings",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Partnumber",
                table: "Packagings",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Direction",
                table: "Packagings",
                type: "character varying(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StoreId",
                table: "ScanInOutTransactions");

            migrationBuilder.RenameColumn(
                name: "ScanInOutTransaction_Id",
                table: "ScanInOutTransactions",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Packaging_Id",
                table: "Packagings",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "MasterStock_Id",
                table: "MasterStocks",
                newName: "Stock_ID");

            migrationBuilder.AlterColumn<string>(
                name: "StoreID",
                table: "Packagings",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Partnumber",
                table: "Packagings",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Direction",
                table: "Packagings",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(50)",
                oldMaxLength: 50);
        }
    }
}
