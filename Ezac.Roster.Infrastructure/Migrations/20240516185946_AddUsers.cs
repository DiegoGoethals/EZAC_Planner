using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ezac.Roster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("053fb830-5a87-452c-a0bf-1a833e98ce01"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0b2a6911-98fc-4782-9cd6-2095c9c7694c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0ee57fdb-9d5a-43de-8ace-d5624a375693"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1554fb57-2c66-409f-aea6-bf5ac9207586"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("161421be-3d59-4498-87ac-e81c13bcb363"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1cfd1867-0437-4336-9d11-234945e82bfe"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("20ff6369-fc29-425f-8bfe-a9078b89c169"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("343c0f7c-7f58-4e4d-9e06-81f28518a7c5"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("34a3abbb-5bfd-492a-8b7b-822c698a319d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("34d1a9dc-6190-442f-a120-51a039f2f0f5"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("3a6dfd03-4844-4754-b3cd-1905908db188"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4f2df5ad-0fff-4411-9a98-8418551caa62"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("519a0348-d47d-45ad-9450-2dda3067b8da"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("571d756a-a360-4a43-83f1-a344f4a78ee3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6261cc61-ccfa-43b8-8862-ef7cf3a4b5a0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6b6223ef-7f8c-4e8a-9fd4-44f3b752a3f3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6f79defe-d0ab-41f6-8271-559b4829941f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7b0c0c78-821d-4989-85d9-498b0c42b2fa"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7fbd5b20-b718-498f-81ba-8722ede1d8b7"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8018e0c4-ae59-4176-a8ab-9de639476ea9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8363a0fa-7cd1-4238-a246-50cd6d58704e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8383a3e6-3582-4eac-b9a1-44e67090e46e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("89f6a626-e9b0-4e1e-bc6e-158625c4b0bd"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8ef5848e-c6d7-437c-a56d-44f781f0f02a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("937be4a4-b8d2-4501-b532-19e58c5b6c5e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("98cc5ccd-e00c-4971-ac9a-f13f233453d2"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a6c43398-142e-419b-a598-b37dbba070c4"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("acdbad76-7fd2-425e-b748-30127f634f5c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ae3b9307-578b-4f7e-b231-899f82cc4a57"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("b067ea0e-567e-4870-ab4a-98e3f8f1ec6d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("b1d01501-6ac0-49de-b524-714be7f4cf11"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("bc6316f2-0478-4abf-9b45-9e55195bdcca"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c39105aa-222a-478b-8f40-b53876b9ebdc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c9c22aaa-927d-45d4-956e-f02ba99a4014"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ca430fdf-36e6-469d-b01e-9a02467756f6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("cf0ee04a-2413-4c94-a80b-0c26bb5e6c18"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d75396d7-9b21-47e9-85df-1c68bbffda4c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d904e8a4-be2f-490d-a54d-9d2bdeaf9f84"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("dd55e726-8f34-4353-9098-3d01116fad92"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e41a26d5-b13f-4fd5-a733-3699dc6ba152"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e937b4dc-7ae7-4183-803e-f753caac03db"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f1eaa953-4d24-4ee1-bf68-50e1e7b5af45"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f55e8612-0123-4f80-aac0-6e08af72cc2f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f722e064-c297-425a-9ff2-bb8b991552ca"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ff0548b3-ab6d-4e17-a2c0-ef198f0877d6"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1c7433fc-808a-4274-9915-79f8e9d20305"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("2276e03f-a432-4582-ae1a-0a7726bb5160"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("311f3a29-7edf-4391-bc3b-1ff17e087afd"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("7af917ac-604e-450e-b5dd-897c504eedbe"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b917b7cd-057e-478a-8e05-51ddd642dad7"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d2f237d1-8bfd-4958-bc99-8cbe0abfaa37"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e8f7926c-13cd-4634-abe3-f2d86ae401f0"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fb9bc8a3-f729-4598-9b2d-ebf7e01f9c0f"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("011b6acf-b4d4-4ceb-8ac3-1f7560d767f5"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("1fad59b4-565c-4b67-9ea4-5d47e0c5bafe"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("2383e557-d0bf-4038-af1b-fa19879d67dc"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("3a0374f4-e1c2-41f1-853c-5c954ba7c5b4"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("452d45b0-dd41-469b-852a-bef968f4236b"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("4943da41-53e4-48bb-9374-37addc4e7420"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("556bfe71-313e-40bf-8f67-1b75188e72c1"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("87bf1e49-7603-451e-a5b5-466129d7684b"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("9e347ddd-02a6-4480-82e6-53b16a159356"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("a841382b-1feb-4274-a172-1a37d1c909e4"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b3f65320-6dd4-46d2-a434-0b3f1e3d4064"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("bc833c73-cfb1-47ff-a2b6-9a8b5b131879"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c4cb0416-e999-4b96-8fd3-e03c57285ac3"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c9caf2e8-4126-4e5d-b574-48fc779ccf13"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("f3b97a25-a427-40bd-84b5-aaeaca3b9f1a"));

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: new Guid("fe6ea702-3c98-4731-903f-31da7623650e"));

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4645), "Zweefvliegkalender", new DateTime(2024, 5, 16, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "Created", "Deleted", "Experience", "Name", "PermissionId", "Updated", "UserId" },
                values: new object[,]
                {
                    { new Guid("052fb947-33dc-4607-867f-d503c4fc8056"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("49c8ee3c-ce63-4d33-93b5-a6e9d1190d9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("550b410d-792a-42f3-a120-e95198e7b486"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("717ff853-8455-4c0f-96df-21670de11468"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("9238367b-5de5-4457-b9b1-9b7ec06a3b8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("9e02b27e-1006-4254-8307-77f40d00e27a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("a9e93b7b-c6a6-46d8-9d0e-51a9cb8013b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("f624ae21-d139-483b-945c-15174c70bd1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Deleted", "Email", "IsAdmin", "Name", "Scaling", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diego@ezac.com", false, "Diego Maradonna", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mitch@ezac.com", false, "Mitch Mitchell", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mileto@ezac.com", false, "Mileto Di Marco", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antoinne@ezac.com", true, "Antoinne De Vlieger", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siegfried@ezac.com", true, "Siegfried Dedeyne", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000013"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dries@ezac.com", false, "Dries Deboosere", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "CalendarId", "Created", "Date", "Deleted", "IsOpen", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("11d7dae0-b223-4166-a71c-e9b3000015d2"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17ef356a-81c9-4e17-b604-fac0d02fec6d"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2121c9ee-f5f1-45a7-8145-ef516153db31"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5bf92d2f-a95a-4dfb-9e76-8e0d45ba9e20"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("61908334-555d-4922-958a-4bfb797dd879"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83bc17bd-a765-4ea7-a9ad-318619a57a47"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("880f4cdc-57e5-46b0-bf03-02a46be47c66"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("94994000-05d1-4e6f-a16d-34b406f56bc6"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9dd07c8f-18aa-4f55-a895-bbb8f162cb68"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a93781bb-1ba9-4433-8976-41e34f402482"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c16ff304-41cb-4fcd-b856-b41904ac553d"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3afbca2-7b2d-4f04-8ed3-b6ee6b6a636e"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e771e9c0-368c-4e1b-84a1-c2d01fb250fe"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e774b603-a555-42e5-b6fc-112ed8023b5e"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f2cabb7c-1551-4923-a1eb-bef8ea12cbef"), new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 20, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "Created", "Deleted", "Experience", "Name", "PermissionId", "Updated", "UserId" },
                values: new object[,]
                {
                    { new Guid("08159788-7712-41b6-8340-4a31da2bbf6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("0a56cc52-5c31-4bd5-aaa7-625a92870565"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("0cccedd9-671f-48f5-a2b0-1c53308c4df9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("1ce3e43d-3baa-4742-8975-6c15c4be9a45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("31a1bc62-6718-470f-826c-5cad6dd49a52"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("364ec593-9d3e-49f1-a82a-f3a8f5fc8537"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("3b8a22f1-572a-4a1e-9e17-ec36077e2e88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("79ccf899-7254-400a-a0b0-8a566f1f59d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("9c33d1ea-85c8-48d0-894e-099cd9676646"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("a626c992-eb6a-403e-b625-ca8ecbe45df6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("b0fc0673-6a1e-4e06-9abb-e7cf52c60f25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("b54fe1fa-d2ac-47e8-b624-a1525b9f8d82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("caceca66-93ce-4789-b098-4a68c11662f8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("e1f13ceb-8210-4724-99f3-a279e6054ad1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("024d521a-8866-40e4-a774-94ca592f32d3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83bc17bd-a765-4ea7-a9ad-318619a57a47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 20, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0615f3ba-b4c3-4a55-b3d6-cb0ff4771604"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f2cabb7c-1551-4923-a1eb-bef8ea12cbef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 23, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0c96bf8f-b709-44ad-a459-d22f89b5cfcf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17ef356a-81c9-4e17-b604-fac0d02fec6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 16, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17e6e0ac-ec49-49ff-be5f-6cad5a5ad04e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e771e9c0-368c-4e1b-84a1-c2d01fb250fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 17, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2a589b7d-da85-4c3e-bbf8-72ba3039330e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83bc17bd-a765-4ea7-a9ad-318619a57a47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 20, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2caee749-6129-472d-ad4e-1f4934c7b2d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a93781bb-1ba9-4433-8976-41e34f402482"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 18, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d6227c8-81bc-464a-8254-ac84a9670a67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c16ff304-41cb-4fcd-b856-b41904ac553d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 24, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3b6064a0-d1f4-4ba1-9120-c5459ec15460"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61908334-555d-4922-958a-4bfb797dd879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 27, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4361e1c7-a76a-4fe4-acf0-444cbc41607e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("880f4cdc-57e5-46b0-bf03-02a46be47c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 28, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45e756ab-9bcd-4c80-9d13-bcb4219c0c81"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9dd07c8f-18aa-4f55-a895-bbb8f162cb68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 29, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4893a92b-f0cf-4b7a-9e9f-cd404356b11f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a93781bb-1ba9-4433-8976-41e34f402482"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 18, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5a181af5-d341-4cd4-84b4-1978bcf5c66f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a93781bb-1ba9-4433-8976-41e34f402482"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 18, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5f1afce4-1b59-4440-ae07-fccf8aa7843d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61908334-555d-4922-958a-4bfb797dd879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 27, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e688dbc-4f16-4b3f-858f-aa0b6c531dff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f2cabb7c-1551-4923-a1eb-bef8ea12cbef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 23, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7679e352-8a41-46c1-8e72-fdf085404482"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3afbca2-7b2d-4f04-8ed3-b6ee6b6a636e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 30, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("76c901cc-6e2c-462a-a71e-1136a83e74cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c16ff304-41cb-4fcd-b856-b41904ac553d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 24, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b7af8e0-5c12-45fc-981d-bff2fc20d46d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94994000-05d1-4e6f-a16d-34b406f56bc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 19, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b8c1008-38d5-461d-a57a-fb6545158eef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("880f4cdc-57e5-46b0-bf03-02a46be47c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 28, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7c80e3ce-642d-450b-a01b-f647a8005f3a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bf92d2f-a95a-4dfb-9e76-8e0d45ba9e20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 26, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81c481a2-e28c-400d-ab93-af953173688a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c16ff304-41cb-4fcd-b856-b41904ac553d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 24, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("871b33ab-94b6-4637-874c-3a37936aaf29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9dd07c8f-18aa-4f55-a895-bbb8f162cb68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 29, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8901ac26-16cd-4266-b010-5251340820ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3afbca2-7b2d-4f04-8ed3-b6ee6b6a636e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 30, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92c3cc93-a4f6-447b-a068-7b91a965f471"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d3afbca2-7b2d-4f04-8ed3-b6ee6b6a636e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 30, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a0c6773-3722-4593-8b79-dbf0680b0ac0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17ef356a-81c9-4e17-b604-fac0d02fec6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 16, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a13ccd8-308f-4eda-8b59-448016600fa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e774b603-a555-42e5-b6fc-112ed8023b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 21, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1d459e5-0864-4590-a305-e9951fa46cd5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9dd07c8f-18aa-4f55-a895-bbb8f162cb68"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 29, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a757f05e-0e3f-48a3-b416-278261068970"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2121c9ee-f5f1-45a7-8145-ef516153db31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 25, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("aa06284e-ca59-417d-9a2a-a93548253601"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("61908334-555d-4922-958a-4bfb797dd879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 27, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("adfdcb70-4765-4e58-b383-725895afcba0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e774b603-a555-42e5-b6fc-112ed8023b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 21, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b576b81a-fa9f-4f67-9f8e-732090407244"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bf92d2f-a95a-4dfb-9e76-8e0d45ba9e20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 26, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9764d76-2907-4e45-9220-a2a5ebcd1327"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("83bc17bd-a765-4ea7-a9ad-318619a57a47"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 20, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c0283cb8-9dad-406c-963b-153145d59edb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e771e9c0-368c-4e1b-84a1-c2d01fb250fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 17, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3cff4c2-47b0-49af-b5f2-e8eb75d49475"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e774b603-a555-42e5-b6fc-112ed8023b5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 21, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c90b1b7a-91cc-4a4d-9e27-e836e0edd9b3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11d7dae0-b223-4166-a71c-e9b3000015d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 22, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d1ab18d4-b052-4f5d-ad1d-03b0377993b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11d7dae0-b223-4166-a71c-e9b3000015d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 22, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d3abbd10-8a48-4f8b-a7f0-0ddc1fc48e9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17ef356a-81c9-4e17-b604-fac0d02fec6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 16, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dca00e67-2331-4d06-b19d-0574efd7bbab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2121c9ee-f5f1-45a7-8145-ef516153db31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 25, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5274311-0f23-4ab7-98ac-a6b9f9a43509"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94994000-05d1-4e6f-a16d-34b406f56bc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 19, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7ac60a9-4d94-4eb2-a2d1-93bfb2d8c743"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("880f4cdc-57e5-46b0-bf03-02a46be47c66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 28, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eba77041-da5b-4ffc-91af-9d54f9556a03"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2121c9ee-f5f1-45a7-8145-ef516153db31"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 25, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ebcdf715-2cf2-4231-bdbc-91c482d9d530"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5bf92d2f-a95a-4dfb-9e76-8e0d45ba9e20"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "A", new DateTime(2024, 5, 26, 5, 29, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f8cb121a-82f4-4202-8bbf-337c72df15b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("11d7dae0-b223-4166-a71c-e9b3000015d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 22, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fddff681-f234-42ed-93f5-9d1e8ed68191"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e771e9c0-368c-4e1b-84a1-c2d01fb250fe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "B", new DateTime(2024, 5, 17, 9, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fe5d25e9-7dba-4bc9-a0e6-c15fe3584db0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("94994000-05d1-4e6f-a16d-34b406f56bc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 19, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fef4abc1-f788-4499-beb7-ee1188953edf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f2cabb7c-1551-4923-a1eb-bef8ea12cbef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 19, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), true, "C", new DateTime(2024, 5, 23, 13, 59, 45, 308, DateTimeKind.Local).AddTicks(4605), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("024d521a-8866-40e4-a774-94ca592f32d3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0615f3ba-b4c3-4a55-b3d6-cb0ff4771604"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0c96bf8f-b709-44ad-a459-d22f89b5cfcf"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("17e6e0ac-ec49-49ff-be5f-6cad5a5ad04e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2a589b7d-da85-4c3e-bbf8-72ba3039330e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2caee749-6129-472d-ad4e-1f4934c7b2d8"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2d6227c8-81bc-464a-8254-ac84a9670a67"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("3b6064a0-d1f4-4ba1-9120-c5459ec15460"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4361e1c7-a76a-4fe4-acf0-444cbc41607e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("45e756ab-9bcd-4c80-9d13-bcb4219c0c81"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4893a92b-f0cf-4b7a-9e9f-cd404356b11f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("5a181af5-d341-4cd4-84b4-1978bcf5c66f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("5f1afce4-1b59-4440-ae07-fccf8aa7843d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6e688dbc-4f16-4b3f-858f-aa0b6c531dff"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7679e352-8a41-46c1-8e72-fdf085404482"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("76c901cc-6e2c-462a-a71e-1136a83e74cc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7b7af8e0-5c12-45fc-981d-bff2fc20d46d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7b8c1008-38d5-461d-a57a-fb6545158eef"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7c80e3ce-642d-450b-a01b-f647a8005f3a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("81c481a2-e28c-400d-ab93-af953173688a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("871b33ab-94b6-4637-874c-3a37936aaf29"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8901ac26-16cd-4266-b010-5251340820ea"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("92c3cc93-a4f6-447b-a068-7b91a965f471"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("9a0c6773-3722-4593-8b79-dbf0680b0ac0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("9a13ccd8-308f-4eda-8b59-448016600fa3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a1d459e5-0864-4590-a305-e9951fa46cd5"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a757f05e-0e3f-48a3-b416-278261068970"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("aa06284e-ca59-417d-9a2a-a93548253601"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("adfdcb70-4765-4e58-b383-725895afcba0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("b576b81a-fa9f-4f67-9f8e-732090407244"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("b9764d76-2907-4e45-9220-a2a5ebcd1327"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c0283cb8-9dad-406c-963b-153145d59edb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c3cff4c2-47b0-49af-b5f2-e8eb75d49475"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c90b1b7a-91cc-4a4d-9e27-e836e0edd9b3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d1ab18d4-b052-4f5d-ad1d-03b0377993b9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d3abbd10-8a48-4f8b-a7f0-0ddc1fc48e9a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("dca00e67-2331-4d06-b19d-0574efd7bbab"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e5274311-0f23-4ab7-98ac-a6b9f9a43509"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e7ac60a9-4d94-4eb2-a2d1-93bfb2d8c743"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("eba77041-da5b-4ffc-91af-9d54f9556a03"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ebcdf715-2cf2-4231-bdbc-91c482d9d530"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f8cb121a-82f4-4202-8bbf-337c72df15b4"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("fddff681-f234-42ed-93f5-9d1e8ed68191"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("fe5d25e9-7dba-4bc9-a0e6-c15fe3584db0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("fef4abc1-f788-4499-beb7-ee1188953edf"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("052fb947-33dc-4607-867f-d503c4fc8056"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("08159788-7712-41b6-8340-4a31da2bbf6f"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("0a56cc52-5c31-4bd5-aaa7-625a92870565"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("0cccedd9-671f-48f5-a2b0-1c53308c4df9"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("1ce3e43d-3baa-4742-8975-6c15c4be9a45"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("31a1bc62-6718-470f-826c-5cad6dd49a52"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("364ec593-9d3e-49f1-a82a-f3a8f5fc8537"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3b8a22f1-572a-4a1e-9e17-ec36077e2e88"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("49c8ee3c-ce63-4d33-93b5-a6e9d1190d9d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("550b410d-792a-42f3-a120-e95198e7b486"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("717ff853-8455-4c0f-96df-21670de11468"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("79ccf899-7254-400a-a0b0-8a566f1f59d6"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("9238367b-5de5-4457-b9b1-9b7ec06a3b8d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("9c33d1ea-85c8-48d0-894e-099cd9676646"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("9e02b27e-1006-4254-8307-77f40d00e27a"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a626c992-eb6a-403e-b625-ca8ecbe45df6"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a9e93b7b-c6a6-46d8-9d0e-51a9cb8013b1"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b0fc0673-6a1e-4e06-9abb-e7cf52c60f25"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b54fe1fa-d2ac-47e8-b624-a1525b9f8d82"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("caceca66-93ce-4789-b098-4a68c11662f8"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("e1f13ceb-8210-4724-99f3-a279e6054ad1"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f624ae21-d139-483b-945c-15174c70bd1a"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("11d7dae0-b223-4166-a71c-e9b3000015d2"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("17ef356a-81c9-4e17-b604-fac0d02fec6d"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("2121c9ee-f5f1-45a7-8145-ef516153db31"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("5bf92d2f-a95a-4dfb-9e76-8e0d45ba9e20"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("61908334-555d-4922-958a-4bfb797dd879"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("83bc17bd-a765-4ea7-a9ad-318619a57a47"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("880f4cdc-57e5-46b0-bf03-02a46be47c66"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("94994000-05d1-4e6f-a16d-34b406f56bc6"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("9dd07c8f-18aa-4f55-a895-bbb8f162cb68"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("a93781bb-1ba9-4433-8976-41e34f402482"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c16ff304-41cb-4fcd-b856-b41904ac553d"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d3afbca2-7b2d-4f04-8ed3-b6ee6b6a636e"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("e771e9c0-368c-4e1b-84a1-c2d01fb250fe"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("e774b603-a555-42e5-b6fc-112ed8023b5e"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("f2cabb7c-1551-4923-a1eb-bef8ea12cbef"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: new Guid("38e954bd-57f1-4a71-a8b9-dda11c1701cb"));

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2498), "Zweefvliegkalender", new DateTime(2024, 5, 14, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "Created", "Deleted", "Experience", "Name", "PermissionId", "Updated", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c7433fc-808a-4274-9915-79f8e9d20305"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("2276e03f-a432-4582-ae1a-0a7726bb5160"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("311f3a29-7edf-4391-bc3b-1ff17e087afd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("7af917ac-604e-450e-b5dd-897c504eedbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("b917b7cd-057e-478a-8e05-51ddd642dad7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("d2f237d1-8bfd-4958-bc99-8cbe0abfaa37"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("e8f7926c-13cd-4634-abe3-f2d86ae401f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("fb9bc8a3-f729-4598-9b2d-ebf7e01f9c0f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "CalendarId", "Created", "Date", "Deleted", "IsOpen", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("011b6acf-b4d4-4ceb-8ac3-1f7560d767f5"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1fad59b4-565c-4b67-9ea4-5d47e0c5bafe"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2383e557-d0bf-4038-af1b-fa19879d67dc"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a0374f4-e1c2-41f1-853c-5c954ba7c5b4"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("452d45b0-dd41-469b-852a-bef968f4236b"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4943da41-53e4-48bb-9374-37addc4e7420"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("556bfe71-313e-40bf-8f67-1b75188e72c1"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("87bf1e49-7603-451e-a5b5-466129d7684b"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9e347ddd-02a6-4480-82e6-53b16a159356"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a841382b-1feb-4274-a172-1a37d1c909e4"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b3f65320-6dd4-46d2-a434-0b3f1e3d4064"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc833c73-cfb1-47ff-a2b6-9a8b5b131879"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c4cb0416-e999-4b96-8fd3-e03c57285ac3"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9caf2e8-4126-4e5d-b574-48fc779ccf13"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f3b97a25-a427-40bd-84b5-aaeaca3b9f1a"), new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("053fb830-5a87-452c-a0bf-1a833e98ce01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2383e557-d0bf-4038-af1b-fa19879d67dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 22, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0b2a6911-98fc-4782-9cd6-2095c9c7694c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c4cb0416-e999-4b96-8fd3-e03c57285ac3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 28, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0ee57fdb-9d5a-43de-8ace-d5624a375693"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4943da41-53e4-48bb-9374-37addc4e7420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 25, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1554fb57-2c66-409f-aea6-bf5ac9207586"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e347ddd-02a6-4480-82e6-53b16a159356"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 15, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("161421be-3d59-4498-87ac-e81c13bcb363"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("011b6acf-b4d4-4ceb-8ac3-1f7560d767f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 19, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1cfd1867-0437-4336-9d11-234945e82bfe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a841382b-1feb-4274-a172-1a37d1c909e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 17, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("20ff6369-fc29-425f-8bfe-a9078b89c169"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("556bfe71-313e-40bf-8f67-1b75188e72c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 18, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("343c0f7c-7f58-4e4d-9e06-81f28518a7c5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87bf1e49-7603-451e-a5b5-466129d7684b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 20, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34a3abbb-5bfd-492a-8b7b-822c698a319d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("452d45b0-dd41-469b-852a-bef968f4236b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 26, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34d1a9dc-6190-442f-a120-51a039f2f0f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9caf2e8-4126-4e5d-b574-48fc779ccf13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 16, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3a6dfd03-4844-4754-b3cd-1905908db188"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a841382b-1feb-4274-a172-1a37d1c909e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 16, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f2df5ad-0fff-4411-9a98-8418551caa62"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2383e557-d0bf-4038-af1b-fa19879d67dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 22, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("519a0348-d47d-45ad-9450-2dda3067b8da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a841382b-1feb-4274-a172-1a37d1c909e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 16, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("571d756a-a360-4a43-83f1-a344f4a78ee3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e347ddd-02a6-4480-82e6-53b16a159356"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 14, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6261cc61-ccfa-43b8-8862-ef7cf3a4b5a0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c4cb0416-e999-4b96-8fd3-e03c57285ac3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 27, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b6223ef-7f8c-4e8a-9fd4-44f3b752a3f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9e347ddd-02a6-4480-82e6-53b16a159356"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 14, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6f79defe-d0ab-41f6-8271-559b4829941f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("556bfe71-313e-40bf-8f67-1b75188e72c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 17, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b0c0c78-821d-4989-85d9-498b0c42b2fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4943da41-53e4-48bb-9374-37addc4e7420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 26, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fbd5b20-b718-498f-81ba-8722ede1d8b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("452d45b0-dd41-469b-852a-bef968f4236b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 26, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8018e0c4-ae59-4176-a8ab-9de639476ea9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("452d45b0-dd41-469b-852a-bef968f4236b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 27, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8363a0fa-7cd1-4238-a246-50cd6d58704e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2383e557-d0bf-4038-af1b-fa19879d67dc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 23, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8383a3e6-3582-4eac-b9a1-44e67090e46e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f3b97a25-a427-40bd-84b5-aaeaca3b9f1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 13, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("89f6a626-e9b0-4e1e-bc6e-158625c4b0bd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1fad59b4-565c-4b67-9ea4-5d47e0c5bafe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 24, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8ef5848e-c6d7-437c-a56d-44f781f0f02a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b3f65320-6dd4-46d2-a434-0b3f1e3d4064"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 21, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("937be4a4-b8d2-4501-b532-19e58c5b6c5e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc833c73-cfb1-47ff-a2b6-9a8b5b131879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 22, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("98cc5ccd-e00c-4971-ac9a-f13f233453d2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc833c73-cfb1-47ff-a2b6-9a8b5b131879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 21, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6c43398-142e-419b-a598-b37dbba070c4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87bf1e49-7603-451e-a5b5-466129d7684b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 19, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("acdbad76-7fd2-425e-b748-30127f634f5c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3a0374f4-e1c2-41f1-853c-5c954ba7c5b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 23, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae3b9307-578b-4f7e-b231-899f82cc4a57"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("011b6acf-b4d4-4ceb-8ac3-1f7560d767f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 18, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b067ea0e-567e-4870-ab4a-98e3f8f1ec6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f3b97a25-a427-40bd-84b5-aaeaca3b9f1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 13, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1d01501-6ac0-49de-b524-714be7f4cf11"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc833c73-cfb1-47ff-a2b6-9a8b5b131879"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 21, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc6316f2-0478-4abf-9b45-9e55195bdcca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3a0374f4-e1c2-41f1-853c-5c954ba7c5b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 24, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c39105aa-222a-478b-8f40-b53876b9ebdc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b3f65320-6dd4-46d2-a434-0b3f1e3d4064"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 20, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c9c22aaa-927d-45d4-956e-f02ba99a4014"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c4cb0416-e999-4b96-8fd3-e03c57285ac3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 27, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ca430fdf-36e6-469d-b01e-9a02467756f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9caf2e8-4126-4e5d-b574-48fc779ccf13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "B", new DateTime(2024, 5, 15, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf0ee04a-2413-4c94-a80b-0c26bb5e6c18"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f3b97a25-a427-40bd-84b5-aaeaca3b9f1a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 14, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d75396d7-9b21-47e9-85df-1c68bbffda4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("3a0374f4-e1c2-41f1-853c-5c954ba7c5b4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 23, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d904e8a4-be2f-490d-a54d-9d2bdeaf9f84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4943da41-53e4-48bb-9374-37addc4e7420"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 25, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd55e726-8f34-4353-9098-3d01116fad92"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c9caf2e8-4126-4e5d-b574-48fc779ccf13"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 15, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e41a26d5-b13f-4fd5-a733-3699dc6ba152"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1fad59b4-565c-4b67-9ea4-5d47e0c5bafe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 24, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e937b4dc-7ae7-4183-803e-f753caac03db"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("556bfe71-313e-40bf-8f67-1b75188e72c1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 17, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1eaa953-4d24-4ee1-bf68-50e1e7b5af45"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b3f65320-6dd4-46d2-a434-0b3f1e3d4064"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 20, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f55e8612-0123-4f80-aac0-6e08af72cc2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("011b6acf-b4d4-4ceb-8ac3-1f7560d767f5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 18, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f722e064-c297-425a-9ff2-bb8b991552ca"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1fad59b4-565c-4b67-9ea4-5d47e0c5bafe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 8, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "C", new DateTime(2024, 5, 25, 2, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff0548b3-ab6d-4e17-a2c0-ef198f0877d6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("87bf1e49-7603-451e-a5b5-466129d7684b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 22, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), true, "A", new DateTime(2024, 5, 19, 18, 10, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }
    }
}
