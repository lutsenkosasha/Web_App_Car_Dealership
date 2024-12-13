using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Car_Dealership.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateV1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccessLevel",
                value: 2);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccessLevel", "HorsePower", "Manufacturer", "Model", "Price", "ProductionYear" },
                values: new object[] { 5, 3, 350, "Porsche", "Cayman 4s", 4000000, 2017 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "AccessLevel",
                value: 1);
        }
    }
}
