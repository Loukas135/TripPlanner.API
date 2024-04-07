using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TripPlanner.API.Migrations
{
    /// <inheritdoc />
    public partial class GovernorateConfigurationAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_AspNetUsers_ApiUserId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0dc5c3b1-80b6-4370-bf36-2a92f190e8ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a2faa59-859f-4455-8e18-8a9289c422ba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6099484c-f523-4e83-b302-2e4edca0c576");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "613f0505-4dd1-412c-aecd-75696d71816f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78f840db-aefa-4fd1-85d1-1d3d9a349564");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8627071b-1820-4570-889d-16afa73c3ca6");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "ApiUserId",
                table: "Services",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d11bada-3f0f-4407-97c7-96dee55b1e70", null, "HotelOwner", "HOTELOWNER" },
                    { "7bf8368b-c915-43bc-9336-13b14acd8830", null, "Administrator", "ADMINISTRATOR" },
                    { "8aea07b8-7085-436f-9b06-dee70e76a24d", null, "Restaurant", "RESTAURANT" },
                    { "acb8b345-637a-4efd-b17f-0a0f19d4e93f", null, "User", "USER" },
                    { "b23f8084-2fc3-4541-b809-3545985b4c2a", null, "CarRental", "CARRENTAL" },
                    { "ba50d554-3c66-4b1e-81c3-1e5fd46f5353", null, "TourismOffice", "TOURISMOFFICE" }
                });

            migrationBuilder.InsertData(
                table: "Governorate",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Damascus is the capital of Syria", "Damascus" },
                    { 2, "Latakia is one of the Syrian governorate", "Latakia" },
                    { 3, "Tartous is one of the Syrian governorate", "Tartous" },
                    { 4, "Aleppo is one of the Syrian governorate", "Aleppo" },
                    { 5, "Daraa is one of the Syrian governorate", "Daraa" },
                    { 6, "Qunaitira is one of the Syrian governorate", "Qunaitira" },
                    { 7, "Sweida is one of the Syrian governorate", "Sweida" },
                    { 8, "Idleb is one of the Syrian governorate", "Idleb" },
                    { 9, "Deir Al Zor is one of the Syrian governorate", "Deir Al Zor" },
                    { 10, "Al Hasaka is one of the Syrian governorate", "Al Hasaka" },
                    { 11, "Qamshli is one of the Syrian governorate", "Qamshli" },
                    { 12, "Al Raqqa is one of the Syrian governorate", "Al Raqqa" },
                    { 13, "Hama is one of the Syrian governorate", "Hama" },
                    { 14, "Liwaa Iskandaron is one of the Syrian governorate", "Liwaa Iskandaron" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_AspNetUsers_ApiUserId",
                table: "Services",
                column: "ApiUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Services_AspNetUsers_ApiUserId",
                table: "Services");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d11bada-3f0f-4407-97c7-96dee55b1e70");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf8368b-c915-43bc-9336-13b14acd8830");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aea07b8-7085-436f-9b06-dee70e76a24d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "acb8b345-637a-4efd-b17f-0a0f19d4e93f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b23f8084-2fc3-4541-b809-3545985b4c2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ba50d554-3c66-4b1e-81c3-1e5fd46f5353");

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Governorate",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.AlterColumn<string>(
                name: "ApiUserId",
                table: "Services",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Services",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0dc5c3b1-80b6-4370-bf36-2a92f190e8ec", null, "Administrator", "ADMINISTRATOR" },
                    { "5a2faa59-859f-4455-8e18-8a9289c422ba", null, "User", "USER" },
                    { "6099484c-f523-4e83-b302-2e4edca0c576", null, "HotelOwner", "HOTELOWNER" },
                    { "613f0505-4dd1-412c-aecd-75696d71816f", null, "TourismOffice", "TOURISMOFFICE" },
                    { "78f840db-aefa-4fd1-85d1-1d3d9a349564", null, "CarRental", "CARRENTAL" },
                    { "8627071b-1820-4570-889d-16afa73c3ca6", null, "Restaurant", "RESTAURANT" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Services_AspNetUsers_ApiUserId",
                table: "Services",
                column: "ApiUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
