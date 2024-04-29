using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TripPlanner.API.Migrations
{
    /// <inheritdoc />
    public partial class hoteladded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fb0ab6c-1bf5-4aa2-a1fb-ae47d2ada376");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ac8b26d-688f-4cad-9e28-aff76f117250");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "667140d7-db29-4326-8610-006c70d0ef95");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "91cf4ed1-4c56-4462-864a-46416243385d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bca7c1f8-b31c-428f-837b-6040e5d24d07");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bcd5fdcb-d055-4427-8938-268b67dd6005");

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

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Address", "ApiUserId", "Description", "GovernorateId", "Name", "ServiceTypeId" },
                values: new object[] { 1, "somewhere", "53efaa18-7ae1-499a-b96c-3e7529c10b42", "good hotel", 1, "ifjas", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fb0ab6c-1bf5-4aa2-a1fb-ae47d2ada376", null, "Administrator", "ADMINISTRATOR" },
                    { "5ac8b26d-688f-4cad-9e28-aff76f117250", null, "HotelOwner", "HOTELOWNER" },
                    { "667140d7-db29-4326-8610-006c70d0ef95", null, "TourismOffice", "TOURISMOFFICE" },
                    { "91cf4ed1-4c56-4462-864a-46416243385d", null, "CarRental", "CARRENTAL" },
                    { "bca7c1f8-b31c-428f-837b-6040e5d24d07", null, "User", "USER" },
                    { "bcd5fdcb-d055-4427-8938-268b67dd6005", null, "Restaurant", "RESTAURANT" }
                });
        }
    }
}
