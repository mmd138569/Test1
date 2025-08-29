using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test1.Migrations
{
    /// <inheritdoc />
    public partial class addnewrelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PersonalID",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PersonalID",
                table: "Orders",
                column: "PersonalID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails",
                column: "ProductID",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Personals_PersonalID",
                table: "Orders",
                column: "PersonalID",
                principalTable: "Personals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Products_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Personals_PersonalID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_PersonalID",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "Date",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "PersonalID",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
