using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Leave_Management.Web.Data.Migrations
{
    public partial class UpdateRequestComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9150e3ee-9e8b-42b1-bbaf-7b459e206f95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1add431eabbf",
                column: "ConcurrencyStamp",
                value: "8f2bcedc-b2a6-47c4-b38c-024348c5eead");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356131e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3363298-0f0a-43f2-8081-f014833773f7", "AQAAAAEAACcQAAAAEFebs5s6TvXsX/l0Cxmc/2vHAOHp2gGjBIzrTp5+xTDgwokZ3DSJtehYqL6+RP0bEg==", "578def88-c421-45d9-be91-5e3099f80ca2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d919f4f-2e1c-4bf7-ac7f-7d1971b957df", "AQAAAAEAACcQAAAAEN3Se1aymW4qpgMiImRFYoaXHJqX19SBoEfELcqftN1OF7K7tm1A8Rpe3Yjswm4K2A==", "0455c952-3cc7-4cab-8632-8673e7ad20bf" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComments",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "1f87e13c-324b-4cfd-b0e2-0ab4d19b6eb6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1add431eabbf",
                column: "ConcurrencyStamp",
                value: "636387e8-30a8-42ef-8873-5926430503de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356131e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9e7690d-8424-4952-8169-819626626c77", "AQAAAAEAACcQAAAAEMLpFLhU3BUXbl5bykMZ1ppUtt1i+6gmY3nMll9aDQS6wIaROOYqwV7FJzx1VfairA==", "8ffb7cb5-e060-40ac-8d1b-692824d16f4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ff70c924-8d94-435f-b86b-15284b743921", "AQAAAAEAACcQAAAAEOl0MYdkyxvK6JAxTIRdtL+1rgh8npD6lVOFhSF6vG4XFgcKszB4rIdqh83fSyes4w==", "65fbb440-acff-4fbe-8a8b-0ac60bc91220" });
        }
    }
}
