using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leave_Management.Web.Data.Migrations
{
    public partial class PeriodAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "261cbd0a-a217-47ec-9e69-4696845ac95c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1add431eabbf",
                column: "ConcurrencyStamp",
                value: "00b724b4-949e-453e-87a1-cbfa6e8f6ed8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356131e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f256d2c8-ffd1-4417-9d39-13a1e2b45242", false, "AQAAAAEAACcQAAAAEG/aaMV8jTpVAlmYs1KnbSftqFC7uk3YIQD10sLbjCK3PgVGZTJaNFN71wzdtkQrTw==", "908ca130-8032-42ba-8c7f-c10b4a6d18ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "89e37246-a759-4e28-a214-ad57efea64b7", false, "AQAAAAEAACcQAAAAECrW2CXLwneLrZw7A7yrlSHSVeUrI6Hel0v5k6kg/K4zC1h2IK73q1XZqEaTR1TP4A==", "082dbb29-b2c9-4d1d-8ed4-0f69b50e92f7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "8c02da5c-fb8c-478b-9c44-096574fd9109");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1add431eabbf",
                column: "ConcurrencyStamp",
                value: "ab89ba6f-f1c1-4e2b-b4d1-11a85f75f116");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356131e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "371968e0-1bd9-4d7e-89e6-620b52ada088", true, "AQAAAAEAACcQAAAAEK/j2ruVBk3f/x8a4QcE1/BFg7O6fs9wmmMuRFbU/itPXtA7zcVgFHVYXmZ1MOvkPg==", "debc4ca7-b240-443c-88ee-d9e6c3e60159" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a35be1a-8a78-435a-91c9-093534350afd", true, "AQAAAAEAACcQAAAAEM4d4Kfu/BkTeQClAFI310omk8ygC9mRvJfqCJJeCR1v6X0W6hmVVrwOrPxBL3dyCQ==", "fa0e8d0a-07a1-4025-b8c3-53d73c05667a" });
        }
    }
}
