using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leave_Management.Web.Data.Migrations
{
    public partial class EmailConfirmTrue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a35be1a-8a78-435a-91c9-093534350afd", true, "ADMIN@EXAMPLE.COM", "AQAAAAEAACcQAAAAEM4d4Kfu/BkTeQClAFI310omk8ygC9mRvJfqCJJeCR1v6X0W6hmVVrwOrPxBL3dyCQ==", "fa0e8d0a-07a1-4025-b8c3-53d73c05667a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "829b776f-e74d-438c-a1d3-4cc67c4653dd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1add431eabbf",
                column: "ConcurrencyStamp",
                value: "fda18e20-ac86-4c4d-a77c-90019b6ec464");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356131e659",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8335b15-d413-49ac-ad88-b95b16f9798d", false, "AQAAAAEAACcQAAAAEJHGc/kbxiFrHneO6f7X6ISy3k/Hi1H6fK3FXVRKTbZZCIEPBQG+ILSYRlG+B+uMlA==", "56b79844-5757-407d-91ed-a96e92ee5925" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0dcc131-79cd-440e-b912-d2cbc788ebda", false, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEEzN4qAVyE0xDNzKX6MaGPqLXNj+E/wzx5w+HGHFQ2HcxfCF46RtwDFi5vBQfopM7A==", "0d4ceeb5-7fe4-4ddd-a289-ed70102442da" });
        }
    }
}
