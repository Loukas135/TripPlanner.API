using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TripPlanner.API.Migrations
{
    /// <inheritdoc />
    public partial class Roomadded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09279641-248e-4514-82ce-f047373b6223");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5579480c-e8cb-4a55-be34-f817ded4d6a3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74723270-2c05-4f1c-aaaf-17076d7140b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "82bd10a1-3b4e-4b08-b031-c851a006113e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b974a2cf-8c15-41aa-b7ae-7f0ca7cf37af");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf101c65-27b9-467a-bf6a-95154842bd89");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "234cbea4-cacb-4ff9-b604-13e41d7c3489", null, "Restaurant", "RESTAURANT" },
                    { "268627f7-115e-476a-aade-d88c280ff128", null, "User", "USER" },
                    { "6bd4cf0f-a99a-4e97-aefd-8376395958ad", null, "HotelOwner", "HOTELOWNER" },
                    { "8148849c-7301-4a77-8a79-a400919c2fbe", null, "TourismOffice", "TOURISMOFFICE" },
                    { "8e9a682e-ac4c-4e62-8868-ffec0353101c", null, "CarRental", "CARRENTAL" },
                    { "fea97f56-e2f2-4b21-9c40-bfb8b2080c82", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "Description", "NumberOfPeople", "PricePerNight", "Quantity", "RoomCategoryId", "ServiceId" },
                values: new object[] { 1, "room no 1", 3, 0f, 1000, 1, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "234cbea4-cacb-4ff9-b604-13e41d7c3489");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "268627f7-115e-476a-aade-d88c280ff128");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6bd4cf0f-a99a-4e97-aefd-8376395958ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8148849c-7301-4a77-8a79-a400919c2fbe");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8e9a682e-ac4c-4e62-8868-ffec0353101c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fea97f56-e2f2-4b21-9c40-bfb8b2080c82");

            migrationBuilder.DeleteData(
                table: "Rooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "09279641-248e-4514-82ce-f047373b6223", null, "CarRental", "CARRENTAL" },
                    { "5579480c-e8cb-4a55-be34-f817ded4d6a3", null, "Administrator", "ADMINISTRATOR" },
                    { "74723270-2c05-4f1c-aaaf-17076d7140b7", null, "TourismOffice", "TOURISMOFFICE" },
                    { "82bd10a1-3b4e-4b08-b031-c851a006113e", null, "User", "USER" },
                    { "b974a2cf-8c15-41aa-b7ae-7f0ca7cf37af", null, "Restaurant", "RESTAURANT" },
                    { "bf101c65-27b9-467a-bf6a-95154842bd89", null, "HotelOwner", "HOTELOWNER" }
                });
        }
    }
}
