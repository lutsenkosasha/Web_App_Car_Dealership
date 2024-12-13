using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Car_Dealership.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreCars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "AccessLevel", "HorsePower", "Manufacturer", "Model", "Price", "ProductionYear" },
                values: new object[,]
                {
                    { 6, 1, 490, "Mercedes-Benz", "S-Class", 10000000, 2020 },
                    { 7, 1, 1020, "Tesla", "Model S", 8000000, 2023 },
                    { 8, 3, 450, "Ford", "Mustang", 5500000, 2022 },
                    { 9, 1, 495, "Chevrolet", "Corvette", 7000000, 2022 },
                    { 10, 2, 335, "Toyota", "Supra", 4000000, 2023 },
                    { 11, 1, 565, "Nissan", "GT-R", 9000000, 2020 },
                    { 12, 2, 612, "Ferrari", "Roma", 24000000, 2022 },
                    { 13, 1, 640, "Lamborghini", "Huracán", 26000000, 2022 },
                    { 14, 3, 575, "Jaguar", "F-Type", 8000000, 2023 },
                    { 15, 2, 550, "Maserati", "GranTurismo", 12000000, 2022 },
                    { 16, 1, 503, "Aston Martin", "DB11", 19000000, 2022 },
                    { 17, 1, 1500, "Bugatti", "Chiron", 30000000, 2023 },
                    { 18, 1, 563, "Rolls-Royce", "Phantom", 28000000, 2023 },
                    { 19, 1, 626, "Bentley", "Continental GT", 25000000, 2023 },
                    { 20, 1, 710, "McLaren", "720S", 25000000, 2023 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);
        }
    }
}
