using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ezac.Roster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_DayPeriods_DayPeriodId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Permissions_PermissionId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_PermissionId",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("00df25d8-b08a-4360-b9fe-8f3289e2d8ad"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("03b12810-4284-45a7-badf-ed17cb8cd138"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("05cda36f-ddf9-4dec-a88b-eebd5ca7f67a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("05cff88a-3706-4eb0-a119-0c11e501a4b0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("08602f88-3014-49d3-bf67-589fd2e2bdbe"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0c4be018-32f0-4871-95f6-2c1dd58c8671"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0cffb1ab-e8f9-4d67-aab9-5e20c3078063"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("11731e2a-ca97-4359-bbd5-055db8defe07"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("19c97464-cdeb-4b01-8ab6-3311fa783d01"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("19e0042d-cce5-40b9-b67e-8cbcd0ac29d9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1e7ad8cf-b69b-4de3-9fbd-dcaa66c5e339"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1f32a955-6420-45e7-ba51-7d3bfa0d68ef"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2142c975-0200-4704-a6e0-5bb45ea9116d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("28c44bd8-d0e7-47d0-9955-322f7a610bbc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2add9afc-31ed-4353-98a1-02ebb272ae62"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2cc8e078-b61a-4bea-89ab-050d2ab975a4"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("321458e3-93ad-45e2-bde3-4477b562f9b0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("32dd3bc5-5ab1-4ecb-a53e-7d6969392f42"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("3ba02c3a-20ce-436d-8f3b-5add4867d132"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("3e8b4c1b-e4df-4166-b8d3-b46bf95732fb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4769e247-9d08-47c8-83f0-ed43efe7aac8"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("49e47a61-b2e7-4421-aaf5-0c7e504ae81e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("50363011-f3b1-4d7c-9566-693ba7d334eb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("516066a7-99e3-4860-b9d2-31a28fccb367"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("57368fe1-2397-4091-8527-56652b9ecc45"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("69cc80d0-b90b-4cc9-b591-e7cd494282a7"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("746ba541-e497-4dc4-adac-6bdb6953cf48"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7a9b3ad3-1b69-42b2-a1a9-16eea5453172"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7f5e0d27-2466-4dc0-bae9-cb73218ad48b"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("939f545b-fe6a-4864-9aec-b0e3d3cb7aa3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a10bd8f9-7f18-4a5c-b15d-e413d60d3345"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("b239b036-fbdd-4488-b819-fae6cc0bfef2"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("b4e03a98-4dc5-4bfd-935b-8d648f0bf5f9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("bf5f978b-91c3-4aa4-a61d-cdf4e1bf2a69"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d39fbb71-4db4-4478-a045-5b3bf95b505d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("df349e51-8ffd-4dae-bc19-4abac5f1213f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e84d3bd0-89ed-4763-a7fc-63aab3b3a5b4"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e9c1d8c9-c0b8-4cc1-947a-081c15b481bf"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e9d19b60-6c61-4ea2-899d-bc575c264db8"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ec652a3c-146d-4373-8fa6-8b5f52e65927"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f5450e99-66a9-42f6-ba01-fcd2e4fa8244"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f67c320e-0830-40df-831d-015ddb6bdc1d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f9caee3e-f8df-41e8-a9ef-8946fceedbd0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("fcacfc1c-8a78-42ec-b938-26a19ecf6a69"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("fcc17d4b-6d6d-4794-996c-748b381861a0"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("0fb48f62-0a8d-4847-a22d-8d7608fa35fd"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("139e538c-f54e-4ad2-9366-54f359a370b7"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("35b619ee-73c9-4a26-86d7-b771be2cd94a"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("40f19b92-5539-4cc4-b48a-471f34c403f4"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("47c10a2b-7406-4f4c-8888-6fc9c98c214f"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("52e1dc86-5f21-41b3-a79e-76d7c3a6e597"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("550eecf2-defb-4436-9c9b-0d6cb74a40d8"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("5823435f-8d3e-4c40-8b1d-d46e139d009c"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("5c1be5ba-c4de-4abf-b9fa-48b71d324fdc"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("63ff453a-e093-488e-b36b-b7abbaff76f9"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("7345eb45-aac9-4e2e-a02b-39974c4aa3f2"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("7f8c7716-ac19-4c18-8bd9-72b2dea156e4"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c661ff4c-d2fc-4311-a526-cc3e200ecbbc"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("dec7804d-805f-4b5d-9b4e-ac5f1b5818ef"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("e8a9b655-8850-408e-9bb7-7da76e0a5438"));

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"));

            migrationBuilder.DropColumn(
                name: "PermissionId",
                table: "Jobs");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<Guid>(
                name: "DayPeriodId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<string>(
                name: "PermissionName",
                table: "Jobs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3693), "Zweefvliegkalender", new DateTime(2024, 5, 8, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Created", "DayPeriodId", "Deleted", "Name", "PermissionName", "Updated", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lierist", "Lierist", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Startofficier", "Startofficier", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bardienst", "Bardienst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instructeur", "Instructeur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instructeur(DDI)", "Instructeur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "CalendarId", "Created", "Date", "Deleted", "IsOpen", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("20588152-4167-48c4-ae4d-0da669a60666"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49fa6205-03af-484f-a53b-9b2baa2b25db"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f2cf8c5-8773-4a06-994a-0ba9d2bcd815"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bbf6d0d-deae-48bc-8411-20922fe4ce3e"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78623b95-a40a-4d9f-bcbb-b18d865cef3e"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7bf87b75-66e5-4ff3-8d4d-9a591fb9b5f4"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("888df71f-b57e-4165-9ee2-56653e7bc0a0"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92ce17e7-6c8d-4634-80a8-4d4b5622625b"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a382f769-96e0-4ccb-a328-bf1eb3564379"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4b53b17-6bb2-4727-9e41-354fb4e1f694"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2905be6-7439-4077-97b3-f57d14aa1911"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3aedb6d-ffb6-42a9-b6c7-58a30eeed7bf"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d6727df2-8484-4bd0-b191-a69d462e8258"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df129749-d09a-4344-98c4-87822bc21380"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e47e3ad4-a57e-4251-bada-9bc1d3aec1e8"), new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 14, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("076717a1-fbd1-44c6-b334-a60ecc671e7f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e47e3ad4-a57e-4251-bada-9bc1d3aec1e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 17, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ef44eef-f8dc-4965-8dae-da6cd0daba17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c2905be6-7439-4077-97b3-f57d14aa1911"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 10, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("118efeb8-2626-4f4a-900c-eb13e6e9aad7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3aedb6d-ffb6-42a9-b6c7-58a30eeed7bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 17, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("215fcc18-49e1-4f9f-87ea-b8727bdcd937"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92ce17e7-6c8d-4634-80a8-4d4b5622625b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 14, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22c7f8c5-8951-4edf-9111-c4e2fc8d0665"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20588152-4167-48c4-ae4d-0da669a60666"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 7, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2e342d61-daf0-485a-b79c-270076d5830b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92ce17e7-6c8d-4634-80a8-4d4b5622625b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 15, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("33537f59-3c0d-4d85-a037-ebd2981e5e36"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4b53b17-6bb2-4727-9e41-354fb4e1f694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 14, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36d0ac31-ec86-451d-a725-0d2d9e8606b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7bf87b75-66e5-4ff3-8d4d-9a591fb9b5f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 16, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40d72cd8-7e6a-466c-8f64-9853c681913d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6727df2-8484-4bd0-b191-a69d462e8258"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 9, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("43b86184-a60e-48a4-b50b-cb2551ebd617"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49fa6205-03af-484f-a53b-9b2baa2b25db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 20, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49c83f79-2443-4bcf-b3ce-13664ea35351"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a382f769-96e0-4ccb-a328-bf1eb3564379"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 10, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("517701e2-4329-498d-834e-a829e6012a6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("888df71f-b57e-4165-9ee2-56653e7bc0a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 21, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52595291-755b-4310-8503-6542ba419efb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78623b95-a40a-4d9f-bcbb-b18d865cef3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 13, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("56146cdf-8d16-421e-81b0-21ebc47baad5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49fa6205-03af-484f-a53b-9b2baa2b25db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 19, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5d9d6d51-cfac-4bbf-b03b-9d6c5b704c83"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6727df2-8484-4bd0-b191-a69d462e8258"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 9, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61726d3c-6fe6-461c-8cb9-434c49b6cfa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bbf6d0d-deae-48bc-8411-20922fe4ce3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 22, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6729883a-a6aa-4400-b9aa-8b10692d7868"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7bf87b75-66e5-4ff3-8d4d-9a591fb9b5f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 16, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("67f63aad-cbcc-40a5-84f8-2981a01ed12f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("888df71f-b57e-4165-9ee2-56653e7bc0a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 21, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ac27315-773a-4aa5-b805-bb8428f9d7fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c2905be6-7439-4077-97b3-f57d14aa1911"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 11, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77641f30-3c10-4c16-bd64-8f74c6b2ed57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3aedb6d-ffb6-42a9-b6c7-58a30eeed7bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 18, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7852f0cd-16d1-40bf-a8d8-bb808872d420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3aedb6d-ffb6-42a9-b6c7-58a30eeed7bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 18, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f403ee2-ac6b-4d44-80e8-495ea4b61783"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d6727df2-8484-4bd0-b191-a69d462e8258"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 8, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f6b062b-2344-47ce-a8ad-4aaac5373fbd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4b53b17-6bb2-4727-9e41-354fb4e1f694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 14, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81cdb9de-8c43-4dcf-8346-2a8e0260ea14"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a382f769-96e0-4ccb-a328-bf1eb3564379"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 9, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8899bc2c-cf74-4d02-b765-a8c5eb762244"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("888df71f-b57e-4165-9ee2-56653e7bc0a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 20, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("93c6cc8e-5be4-4c38-8477-7cc4ae93c52f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f2cf8c5-8773-4a06-994a-0ba9d2bcd815"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 12, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9bdd5800-79e0-43d0-ba8e-70ad5bee0086"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78623b95-a40a-4d9f-bcbb-b18d865cef3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 12, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0050c12-c59c-4a59-916f-f783ff57ee9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f2cf8c5-8773-4a06-994a-0ba9d2bcd815"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 11, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a11b8503-bdaf-4d7e-87ad-ea21ad4b494e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bbf6d0d-deae-48bc-8411-20922fe4ce3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 21, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a5484377-d5c9-488c-9e01-df2dfa8af819"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e47e3ad4-a57e-4251-bada-9bc1d3aec1e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 17, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a81b75a3-ce4f-4aa2-b39a-aed10bf0e778"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4f2cf8c5-8773-4a06-994a-0ba9d2bcd815"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 12, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("acce0230-d92e-4e95-9dcb-f757e6f10158"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7bf87b75-66e5-4ff3-8d4d-9a591fb9b5f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 15, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2f625a4-3192-484e-bd16-f2c10df75694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("49fa6205-03af-484f-a53b-9b2baa2b25db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 20, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb8da873-48fd-4a88-824e-ce1150f16bdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a382f769-96e0-4ccb-a328-bf1eb3564379"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 10, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce11e849-66e1-4856-8345-75b38a636e82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b4b53b17-6bb2-4727-9e41-354fb4e1f694"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 13, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce7dee0e-b9eb-447e-9a7d-647efca3fa75"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df129749-d09a-4344-98c4-87822bc21380"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 19, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d0f1310b-0d90-4c77-b8cb-a22add8e1964"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e47e3ad4-a57e-4251-bada-9bc1d3aec1e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 16, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d399f8f4-b41d-4d57-8eda-4761aea9d252"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df129749-d09a-4344-98c4-87822bc21380"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "A", new DateTime(2024, 5, 18, 22, 44, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5cdcb8d-b2ac-41ad-b7ec-6857a0bdb4fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bbf6d0d-deae-48bc-8411-20922fe4ce3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 22, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d5d1e28f-6850-4a9a-bf7a-1db8233885a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c2905be6-7439-4077-97b3-f57d14aa1911"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 11, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e595e703-d949-43a0-9201-4a534910a69d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20588152-4167-48c4-ae4d-0da669a60666"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 8, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6f4d76d-3564-41f6-9fc4-3bb66c0ab995"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78623b95-a40a-4d9f-bcbb-b18d865cef3e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "B", new DateTime(2024, 5, 13, 3, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1bbb302-a399-478b-bb2f-f23ff181c0e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92ce17e7-6c8d-4634-80a8-4d4b5622625b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 15, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5908fd1-21bc-4831-a0c2-9248f527b910"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("20588152-4167-48c4-ae4d-0da669a60666"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 8, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f709b112-4f4d-420a-b274-b5df591f452f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("df129749-d09a-4344-98c4-87822bc21380"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 13, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), true, "C", new DateTime(2024, 5, 19, 7, 14, 11, 959, DateTimeKind.Local).AddTicks(3642), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_DayPeriods_DayPeriodId",
                table: "Jobs",
                column: "DayPeriodId",
                principalTable: "DayPeriods",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_DayPeriods_DayPeriodId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs");

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("076717a1-fbd1-44c6-b334-a60ecc671e7f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0ef44eef-f8dc-4965-8dae-da6cd0daba17"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("118efeb8-2626-4f4a-900c-eb13e6e9aad7"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("215fcc18-49e1-4f9f-87ea-b8727bdcd937"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("22c7f8c5-8951-4edf-9111-c4e2fc8d0665"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2e342d61-daf0-485a-b79c-270076d5830b"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("33537f59-3c0d-4d85-a037-ebd2981e5e36"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("36d0ac31-ec86-451d-a725-0d2d9e8606b5"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("40d72cd8-7e6a-466c-8f64-9853c681913d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("43b86184-a60e-48a4-b50b-cb2551ebd617"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("49c83f79-2443-4bcf-b3ce-13664ea35351"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("517701e2-4329-498d-834e-a829e6012a6d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("52595291-755b-4310-8503-6542ba419efb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("56146cdf-8d16-421e-81b0-21ebc47baad5"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("5d9d6d51-cfac-4bbf-b03b-9d6c5b704c83"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("61726d3c-6fe6-461c-8cb9-434c49b6cfa3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6729883a-a6aa-4400-b9aa-8b10692d7868"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("67f63aad-cbcc-40a5-84f8-2981a01ed12f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6ac27315-773a-4aa5-b805-bb8428f9d7fc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("77641f30-3c10-4c16-bd64-8f74c6b2ed57"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7852f0cd-16d1-40bf-a8d8-bb808872d420"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7f403ee2-ac6b-4d44-80e8-495ea4b61783"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7f6b062b-2344-47ce-a8ad-4aaac5373fbd"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("81cdb9de-8c43-4dcf-8346-2a8e0260ea14"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8899bc2c-cf74-4d02-b765-a8c5eb762244"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("93c6cc8e-5be4-4c38-8477-7cc4ae93c52f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("9bdd5800-79e0-43d0-ba8e-70ad5bee0086"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a0050c12-c59c-4a59-916f-f783ff57ee9d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a11b8503-bdaf-4d7e-87ad-ea21ad4b494e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a5484377-d5c9-488c-9e01-df2dfa8af819"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a81b75a3-ce4f-4aa2-b39a-aed10bf0e778"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("acce0230-d92e-4e95-9dcb-f757e6f10158"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c2f625a4-3192-484e-bd16-f2c10df75694"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("cb8da873-48fd-4a88-824e-ce1150f16bdc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ce11e849-66e1-4856-8345-75b38a636e82"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ce7dee0e-b9eb-447e-9a7d-647efca3fa75"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d0f1310b-0d90-4c77-b8cb-a22add8e1964"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d399f8f4-b41d-4d57-8eda-4761aea9d252"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d5cdcb8d-b2ac-41ad-b7ec-6857a0bdb4fa"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d5d1e28f-6850-4a9a-bf7a-1db8233885a5"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e595e703-d949-43a0-9201-4a534910a69d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e6f4d76d-3564-41f6-9fc4-3bb66c0ab995"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f1bbb302-a399-478b-bb2f-f23ff181c0e0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f5908fd1-21bc-4831-a0c2-9248f527b910"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f709b112-4f4d-420a-b274-b5df591f452f"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Jobs",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("20588152-4167-48c4-ae4d-0da669a60666"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("49fa6205-03af-484f-a53b-9b2baa2b25db"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("4f2cf8c5-8773-4a06-994a-0ba9d2bcd815"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("5bbf6d0d-deae-48bc-8411-20922fe4ce3e"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("78623b95-a40a-4d9f-bcbb-b18d865cef3e"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("7bf87b75-66e5-4ff3-8d4d-9a591fb9b5f4"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("888df71f-b57e-4165-9ee2-56653e7bc0a0"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("92ce17e7-6c8d-4634-80a8-4d4b5622625b"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("a382f769-96e0-4ccb-a328-bf1eb3564379"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b4b53b17-6bb2-4727-9e41-354fb4e1f694"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c2905be6-7439-4077-97b3-f57d14aa1911"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d3aedb6d-ffb6-42a9-b6c7-58a30eeed7bf"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d6727df2-8484-4bd0-b191-a69d462e8258"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("df129749-d09a-4344-98c4-87822bc21380"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("e47e3ad4-a57e-4251-bada-9bc1d3aec1e8"));

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: new Guid("c70cda7e-6cf2-476a-9d2e-b2dc0247498b"));

            migrationBuilder.DropColumn(
                name: "PermissionName",
                table: "Jobs");

            migrationBuilder.AlterColumn<Guid>(
                name: "UserId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "DayPeriodId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PermissionId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8046), "Zweefvliegkalender", new DateTime(2024, 5, 8, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "CalendarId", "Created", "Date", "Deleted", "IsOpen", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("0fb48f62-0a8d-4847-a22d-8d7608fa35fd"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("139e538c-f54e-4ad2-9366-54f359a370b7"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("35b619ee-73c9-4a26-86d7-b771be2cd94a"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("40f19b92-5539-4cc4-b48a-471f34c403f4"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("47c10a2b-7406-4f4c-8888-6fc9c98c214f"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("52e1dc86-5f21-41b3-a79e-76d7c3a6e597"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("550eecf2-defb-4436-9c9b-0d6cb74a40d8"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5823435f-8d3e-4c40-8b1d-d46e139d009c"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5c1be5ba-c4de-4abf-b9fa-48b71d324fdc"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63ff453a-e093-488e-b36b-b7abbaff76f9"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7345eb45-aac9-4e2e-a02b-39974c4aa3f2"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f8c7716-ac19-4c18-8bd9-72b2dea156e4"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c661ff4c-d2fc-4311-a526-cc3e200ecbbc"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dec7804d-805f-4b5d-9b4e-ac5f1b5818ef"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e8a9b655-8850-408e-9bb7-7da76e0a5438"), new Guid("d6cf6e97-b9cc-47a9-a7d4-2ec8219d2f35"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 9, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("00df25d8-b08a-4360-b9fe-8f3289e2d8ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c661ff4c-d2fc-4311-a526-cc3e200ecbbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 7, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 7, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("03b12810-4284-45a7-badf-ed17cb8cd138"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63ff453a-e093-488e-b36b-b7abbaff76f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 18, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05cda36f-ddf9-4dec-a88b-eebd5ca7f67a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("47c10a2b-7406-4f4c-8888-6fc9c98c214f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 22, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("05cff88a-3706-4eb0-a119-0c11e501a4b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fb48f62-0a8d-4847-a22d-8d7608fa35fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 13, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("08602f88-3014-49d3-bf67-589fd2e2bdbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35b619ee-73c9-4a26-86d7-b771be2cd94a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 16, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c4be018-32f0-4871-95f6-2c1dd58c8671"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c1be5ba-c4de-4abf-b9fa-48b71d324fdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 8, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0cffb1ab-e8f9-4d67-aab9-5e20c3078063"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("52e1dc86-5f21-41b3-a79e-76d7c3a6e597"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 11, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("11731e2a-ca97-4359-bbd5-055db8defe07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("139e538c-f54e-4ad2-9366-54f359a370b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 18, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("19c97464-cdeb-4b01-8ab6-3311fa783d01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dec7804d-805f-4b5d-9b4e-ac5f1b5818ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 13, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("19e0042d-cce5-40b9-b67e-8cbcd0ac29d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("47c10a2b-7406-4f4c-8888-6fc9c98c214f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 21, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1e7ad8cf-b69b-4de3-9fbd-dcaa66c5e339"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("550eecf2-defb-4436-9c9b-0d6cb74a40d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 9, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f32a955-6420-45e7-ba51-7d3bfa0d68ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35b619ee-73c9-4a26-86d7-b771be2cd94a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 15, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2142c975-0200-4704-a6e0-5bb45ea9116d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c661ff4c-d2fc-4311-a526-cc3e200ecbbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 8, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("28c44bd8-d0e7-47d0-9955-322f7a610bbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("52e1dc86-5f21-41b3-a79e-76d7c3a6e597"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 12, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2add9afc-31ed-4353-98a1-02ebb272ae62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5823435f-8d3e-4c40-8b1d-d46e139d009c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 14, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2cc8e078-b61a-4bea-89ab-050d2ab975a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5823435f-8d3e-4c40-8b1d-d46e139d009c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 14, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("321458e3-93ad-45e2-bde3-4477b562f9b0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c1be5ba-c4de-4abf-b9fa-48b71d324fdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 8, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("32dd3bc5-5ab1-4ecb-a53e-7d6969392f42"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fb48f62-0a8d-4847-a22d-8d7608fa35fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 14, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ba02c3a-20ce-436d-8f3b-5add4867d132"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c661ff4c-d2fc-4311-a526-cc3e200ecbbc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 7, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3e8b4c1b-e4df-4166-b8d3-b46bf95732fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("35b619ee-73c9-4a26-86d7-b771be2cd94a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 15, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4769e247-9d08-47c8-83f0-ed43efe7aac8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("40f19b92-5539-4cc4-b48a-471f34c403f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 19, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49e47a61-b2e7-4421-aaf5-0c7e504ae81e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("139e538c-f54e-4ad2-9366-54f359a370b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 17, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50363011-f3b1-4d7c-9566-693ba7d334eb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("47c10a2b-7406-4f4c-8888-6fc9c98c214f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 21, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("516066a7-99e3-4860-b9d2-31a28fccb367"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dec7804d-805f-4b5d-9b4e-ac5f1b5818ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 12, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("57368fe1-2397-4091-8527-56652b9ecc45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e8a9b655-8850-408e-9bb7-7da76e0a5438"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 10, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("69cc80d0-b90b-4cc9-b591-e7cd494282a7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7f8c7716-ac19-4c18-8bd9-72b2dea156e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 20, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("746ba541-e497-4dc4-adac-6bdb6953cf48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7345eb45-aac9-4e2e-a02b-39974c4aa3f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 16, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a9b3ad3-1b69-42b2-a1a9-16eea5453172"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("40f19b92-5539-4cc4-b48a-471f34c403f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 19, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7f5e0d27-2466-4dc0-bae9-cb73218ad48b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("52e1dc86-5f21-41b3-a79e-76d7c3a6e597"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 11, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("939f545b-fe6a-4864-9aec-b0e3d3cb7aa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5c1be5ba-c4de-4abf-b9fa-48b71d324fdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 9, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a10bd8f9-7f18-4a5c-b15d-e413d60d3345"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63ff453a-e093-488e-b36b-b7abbaff76f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 18, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b239b036-fbdd-4488-b819-fae6cc0bfef2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dec7804d-805f-4b5d-9b4e-ac5f1b5818ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 12, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b4e03a98-4dc5-4bfd-935b-8d648f0bf5f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e8a9b655-8850-408e-9bb7-7da76e0a5438"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 11, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf5f978b-91c3-4aa4-a61d-cdf4e1bf2a69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("550eecf2-defb-4436-9c9b-0d6cb74a40d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 9, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d39fbb71-4db4-4478-a045-5b3bf95b505d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7345eb45-aac9-4e2e-a02b-39974c4aa3f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 16, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("df349e51-8ffd-4dae-bc19-4abac5f1213f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63ff453a-e093-488e-b36b-b7abbaff76f9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 19, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e84d3bd0-89ed-4763-a7fc-63aab3b3a5b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5823435f-8d3e-4c40-8b1d-d46e139d009c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 15, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9c1d8c9-c0b8-4cc1-947a-081c15b481bf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fb48f62-0a8d-4847-a22d-8d7608fa35fd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 13, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e9d19b60-6c61-4ea2-899d-bc575c264db8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e8a9b655-8850-408e-9bb7-7da76e0a5438"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 10, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ec652a3c-146d-4373-8fa6-8b5f52e65927"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("40f19b92-5539-4cc4-b48a-471f34c403f4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 20, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5450e99-66a9-42f6-ba01-fcd2e4fa8244"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7f8c7716-ac19-4c18-8bd9-72b2dea156e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "A", new DateTime(2024, 5, 20, 17, 38, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f67c320e-0830-40df-831d-015ddb6bdc1d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7f8c7716-ac19-4c18-8bd9-72b2dea156e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 21, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9caee3e-f8df-41e8-a9ef-8946fceedbd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("139e538c-f54e-4ad2-9366-54f359a370b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "B", new DateTime(2024, 5, 17, 22, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fcacfc1c-8a78-42ec-b938-26a19ecf6a69"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7345eb45-aac9-4e2e-a02b-39974c4aa3f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 17, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fcc17d4b-6d6d-4794-996c-748b381861a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("550eecf2-defb-4436-9c9b-0d6cb74a40d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 8, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), true, "C", new DateTime(2024, 5, 10, 2, 8, 22, 312, DateTimeKind.Local).AddTicks(8000), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_PermissionId",
                table: "Jobs",
                column: "PermissionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_DayPeriods_DayPeriodId",
                table: "Jobs",
                column: "DayPeriodId",
                principalTable: "DayPeriods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Permissions_PermissionId",
                table: "Jobs",
                column: "PermissionId",
                principalTable: "Permissions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
