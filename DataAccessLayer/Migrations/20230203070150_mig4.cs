using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_CarWashes_CarWashId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customers",
                table: "Customers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarWashes",
                table: "CarWashes");

            migrationBuilder.DropColumn(
                name: "CustomerImage1",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CustomerImage2",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "CarWashPhoneNumber",
                table: "CarWashes");

            migrationBuilder.DropColumn(
                name: "ClientNumber",
                table: "CarWashes");

            migrationBuilder.RenameTable(
                name: "Customers",
                newName: "Customer");

            migrationBuilder.RenameTable(
                name: "CarWashes",
                newName: "CarWash");

            migrationBuilder.RenameColumn(
                name: "CustomerPhoneNumber",
                table: "Customer",
                newName: "PhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "CarWash",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "CarWash",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customer",
                table: "Customer",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarWash",
                table: "CarWash",
                column: "CarWashId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_CarWash_CarWashId",
                table: "Appointments",
                column: "CarWashId",
                principalTable: "CarWash",
                principalColumn: "CarWashId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customer_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_CarWash_CarWashId",
                table: "Appointments");

            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_Customer_CustomerId",
                table: "Appointments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Customer",
                table: "Customer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CarWash",
                table: "CarWash");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Customer");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "CarWash");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "CarWash");

            migrationBuilder.RenameTable(
                name: "Customer",
                newName: "Customers");

            migrationBuilder.RenameTable(
                name: "CarWash",
                newName: "CarWashes");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "Customers",
                newName: "CustomerPhoneNumber");

            migrationBuilder.AddColumn<string>(
                name: "CustomerImage1",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CustomerImage2",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CarWashPhoneNumber",
                table: "CarWashes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ClientNumber",
                table: "CarWashes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Customers",
                table: "Customers",
                column: "CustomerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CarWashes",
                table: "CarWashes",
                column: "CarWashId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_CarWashes_CarWashId",
                table: "Appointments",
                column: "CarWashId",
                principalTable: "CarWashes",
                principalColumn: "CarWashId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_Customers_CustomerId",
                table: "Appointments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
