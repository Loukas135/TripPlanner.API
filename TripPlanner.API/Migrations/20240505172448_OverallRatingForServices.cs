using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TripPlanner.API.Migrations
{
    /// <inheritdoc />
    public partial class OverallRatingForServices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2069d6a8-dd5a-4664-8322-b77c41e1aad3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4557a5af-f3f2-407e-aba2-02c7da4071a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74df9ed8-1f6f-445b-ab44-c318b48fc0a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f335e5b-137f-43f1-a6ef-0d95061470fd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b2887be9-4840-4ce5-a751-3631151aded7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff1a8180-83c2-4c88-b956-972c687ed111");

            migrationBuilder.AddColumn<int>(
                name: "Overall_Rating",
                table: "Services",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1495703b-95cb-4b35-898e-b1f76a4c0c7e", null, "User", "USER" },
                    { "45cc3e14-a093-4ff6-ad10-a5bdd6caf334", null, "Restaurant", "RESTAURANT" },
                    { "552ac602-16b7-4c9e-8a4e-17fc530e7003", null, "CarRental", "CARRENTAL" },
                    { "8aa306e1-bba2-4185-8151-87b54a273a5c", null, "HotelOwner", "HOTELOWNER" },
                    { "97605af6-45c0-42a8-b86b-5e0c554eff37", null, "Administrator", "ADMINISTRATOR" },
                    { "d6f90178-8a37-4580-b99b-1ca2a1201f00", null, "TourismOffice", "TOURISMOFFICE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1495703b-95cb-4b35-898e-b1f76a4c0c7e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45cc3e14-a093-4ff6-ad10-a5bdd6caf334");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "552ac602-16b7-4c9e-8a4e-17fc530e7003");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aa306e1-bba2-4185-8151-87b54a273a5c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "97605af6-45c0-42a8-b86b-5e0c554eff37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6f90178-8a37-4580-b99b-1ca2a1201f00");

            migrationBuilder.DropColumn(
                name: "Overall_Rating",
                table: "Services");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2069d6a8-dd5a-4664-8322-b77c41e1aad3", null, "User", "USER" },
                    { "4557a5af-f3f2-407e-aba2-02c7da4071a4", null, "Administrator", "ADMINISTRATOR" },
                    { "74df9ed8-1f6f-445b-ab44-c318b48fc0a4", null, "CarRental", "CARRENTAL" },
                    { "9f335e5b-137f-43f1-a6ef-0d95061470fd", null, "HotelOwner", "HOTELOWNER" },
                    { "b2887be9-4840-4ce5-a751-3631151aded7", null, "Restaurant", "RESTAURANT" },
                    { "ff1a8180-83c2-4c88-b956-972c687ed111", null, "TourismOffice", "TOURISMOFFICE" }
                });
        }
    }
}
