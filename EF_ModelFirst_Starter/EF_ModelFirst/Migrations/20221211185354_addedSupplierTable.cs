using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFModelFirst.Migrations
{
    /// <inheritdoc />
    public partial class addedSupplierTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "OrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SupplierCountry = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Supplier", x => x.SupplierId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_SupplierId",
                table: "OrderDetails",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Supplier_SupplierId",
                table: "OrderDetails",
                column: "SupplierId",
                principalTable: "Supplier",
                principalColumn: "SupplierId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Supplier_SupplierId",
                table: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_SupplierId",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "OrderDetails");
        }
    }
}
