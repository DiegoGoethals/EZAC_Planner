using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ezac.Roster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class dataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 8, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2953), "Zweefvliegkalender", new DateTime(2024, 5, 8, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "Created", "Deleted", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lierist", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Startofficier", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bardienst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Instructeur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Created", "Deleted", "Email", "IsAdmin", "Name", "Scaling", "Updated" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000005"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "johnny@ezac.com", false, "Johnny Debeer", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000006"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alfie@ezac.com", false, "Alfonso Rosseel", 0.5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@ezac.com", true, "Mohammed Ali", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "CalendarId", "Created", "Date", "Deleted", "IsOpen", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("00bbbd24-b99b-4f14-8ff2-75d8a5d9c801"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d5eef61-d6a9-46de-ad55-673d60917113"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("36d780c1-959f-4480-8698-ea91e273065b"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("54e23e5f-c2d2-4bb5-82fa-176a7db9972f"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("736d1928-a0e7-4c1c-b4de-a2be70408178"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8146a091-1fc3-4d87-90d7-43b97151e834"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b1616c2e-e72a-4ca8-a133-3c9175692361"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8cefcd3-99e0-4849-8062-48f891f99fb2"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b9aab22c-e2ff-47f7-8860-c44466757053"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c7290798-7d9f-494d-8ddc-c3efc0c79d04"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d4de14da-e0eb-4188-b942-305f988c29b7"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7f935c4-278b-4f95-b802-73543433f659"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e071a88e-b79e-4c1a-ad59-b2dde43204a5"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9d2b92b-6caa-4c0f-992e-f5d9fe2afc80"), new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 9, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "PermissionUser",
                columns: new[] { "PermissionsId", "UsersId" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000007") }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("04a3c594-797c-4225-a0c0-79ea404025da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2d5eef61-d6a9-46de-ad55-673d60917113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 15, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09980fa3-9b8e-4a7f-a2fb-d116dab4c5da"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e071a88e-b79e-4c1a-ad59-b2dde43204a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 12, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d208ce8-78b2-4a32-be7e-f42381172753"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("54e23e5f-c2d2-4bb5-82fa-176a7db9972f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 9, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1154025b-deae-4235-87e6-903d74dac087"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d7f935c4-278b-4f95-b802-73543433f659"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 14, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2264e7cf-1ccc-4035-9a2e-6e1207ef6e9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00bbbd24-b99b-4f14-8ff2-75d8a5d9c801"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 18, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2285474e-015d-46fb-aa5e-a5c16e786aa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7290798-7d9f-494d-8ddc-c3efc0c79d04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 17, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("25255ead-bf89-4e82-92ad-a63ae515d71e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9aab22c-e2ff-47f7-8860-c44466757053"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 19, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2687c773-6e67-41ba-a412-1e649c19e71c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2d5eef61-d6a9-46de-ad55-673d60917113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 16, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2ded5841-8211-4229-b864-ad36be89ddd6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("736d1928-a0e7-4c1c-b4de-a2be70408178"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 11, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4873e4d8-74f3-437e-b6fe-41e24cffbbec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4de14da-e0eb-4188-b942-305f988c29b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 21, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4c20f89c-cbea-4433-933e-bf39496801fc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d7f935c4-278b-4f95-b802-73543433f659"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 14, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e2a2415-5f77-4783-8b42-6ec477f99248"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("54e23e5f-c2d2-4bb5-82fa-176a7db9972f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 8, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 8, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("55b2beeb-2871-457c-94e3-87ad44084bc6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8146a091-1fc3-4d87-90d7-43b97151e834"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 10, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b9d8421-e272-42bf-8cad-cd0ea01700d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b1616c2e-e72a-4ca8-a133-3c9175692361"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 11, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e42af9b-f4a8-4500-bb12-4c31b3f63195"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8146a091-1fc3-4d87-90d7-43b97151e834"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 9, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6e49759b-3019-4b0c-a511-4cfd7a974f0b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e071a88e-b79e-4c1a-ad59-b2dde43204a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 12, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("70eee5a3-e22c-4718-b4ed-93b28030b465"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("736d1928-a0e7-4c1c-b4de-a2be70408178"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 10, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7620dcc3-dc15-4884-9fac-5ca9d57d8be6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8cefcd3-99e0-4849-8062-48f891f99fb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 20, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78df6c1f-ef7b-4065-8057-ff42aa65ac09"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b1616c2e-e72a-4ca8-a133-3c9175692361"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 12, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 12, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7fe2f2e8-96cb-4d98-929c-111512e15183"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b1616c2e-e72a-4ca8-a133-3c9175692361"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 11, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 11, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("83a00c23-aa2c-4493-a275-4e89ed37e063"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7290798-7d9f-494d-8ddc-c3efc0c79d04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 16, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("85c79c34-0090-45c7-a50c-f6bbcd79a188"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00bbbd24-b99b-4f14-8ff2-75d8a5d9c801"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 17, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8d0b2bbd-61d9-491a-a9ab-3378a036488f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00bbbd24-b99b-4f14-8ff2-75d8a5d9c801"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 17, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92554e8a-074b-41a3-822e-15daa01f2270"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("36d780c1-959f-4480-8698-ea91e273065b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 18, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a6700cb7-a340-4e19-887f-db5ac7eaf375"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8146a091-1fc3-4d87-90d7-43b97151e834"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 9, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a73e7c3e-cfca-4278-a0ea-5302d37abe43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("736d1928-a0e7-4c1c-b4de-a2be70408178"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 10, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 10, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac9394d2-0bfa-42fe-a021-9ccdf7c63d19"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e071a88e-b79e-4c1a-ad59-b2dde43204a5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 13, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad9223b4-bc9e-422e-ab7f-c8508f1eff4b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9d2b92b-6caa-4c0f-992e-f5d9fe2afc80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 14, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ae261741-e74a-4624-baaf-074734ed182c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8cefcd3-99e0-4849-8062-48f891f99fb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 21, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 21, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc01372b-d851-4bd1-a72c-d51f447d35a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c7290798-7d9f-494d-8ddc-c3efc0c79d04"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 17, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 16, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc0c105a-1627-4292-84f6-f76b64038ddb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("36d780c1-959f-4480-8698-ea91e273065b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 18, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 18, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bccefd26-9e26-4ac4-aa31-34ff2a5361e0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9aab22c-e2ff-47f7-8860-c44466757053"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 19, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c76845a1-4ab1-4864-a693-9c9a42cbb12a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9d2b92b-6caa-4c0f-992e-f5d9fe2afc80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 14, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 13, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c85a0404-1649-40e1-ba94-dc36a7f9d184"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("54e23e5f-c2d2-4bb5-82fa-176a7db9972f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 9, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 8, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cf33b3c8-6b09-4856-be2d-92e29d991b63"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4de14da-e0eb-4188-b942-305f988c29b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 22, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d8fc8c57-fa1b-43aa-93e9-d49947009ebd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f9d2b92b-6caa-4c0f-992e-f5d9fe2afc80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 13, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 13, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e446ed35-0512-457e-add6-ea0c21f31a6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b9aab22c-e2ff-47f7-8860-c44466757053"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 20, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e7036b35-f07f-4e64-8f86-8392be3e4f4c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d4de14da-e0eb-4188-b942-305f988c29b7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 21, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eed31ac7-d56c-49c9-9668-066c059655ab"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8cefcd3-99e0-4849-8062-48f891f99fb2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 20, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "A", new DateTime(2024, 5, 20, 17, 32, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef9532c6-e301-4ee2-ad07-5a80b3894346"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("36d780c1-959f-4480-8698-ea91e273065b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 19, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 19, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f39b38b9-d732-44e8-a0a2-9ab0fae77000"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d7f935c4-278b-4f95-b802-73543433f659"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 15, 8, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "C", new DateTime(2024, 5, 15, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fc5b1fd2-1a5f-4736-8fed-a02948efe102"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2d5eef61-d6a9-46de-ad55-673d60917113"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 16, 2, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), true, "B", new DateTime(2024, 5, 15, 22, 2, 42, 216, DateTimeKind.Local).AddTicks(2913), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("04a3c594-797c-4225-a0c0-79ea404025da"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("09980fa3-9b8e-4a7f-a2fb-d116dab4c5da"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0d208ce8-78b2-4a32-be7e-f42381172753"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1154025b-deae-4235-87e6-903d74dac087"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2264e7cf-1ccc-4035-9a2e-6e1207ef6e9e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2285474e-015d-46fb-aa5e-a5c16e786aa3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("25255ead-bf89-4e82-92ad-a63ae515d71e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2687c773-6e67-41ba-a412-1e649c19e71c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2ded5841-8211-4229-b864-ad36be89ddd6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4873e4d8-74f3-437e-b6fe-41e24cffbbec"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4c20f89c-cbea-4433-933e-bf39496801fc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4e2a2415-5f77-4783-8b42-6ec477f99248"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("55b2beeb-2871-457c-94e3-87ad44084bc6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6b9d8421-e272-42bf-8cad-cd0ea01700d1"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6e42af9b-f4a8-4500-bb12-4c31b3f63195"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6e49759b-3019-4b0c-a511-4cfd7a974f0b"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("70eee5a3-e22c-4718-b4ed-93b28030b465"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7620dcc3-dc15-4884-9fac-5ca9d57d8be6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("78df6c1f-ef7b-4065-8057-ff42aa65ac09"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7fe2f2e8-96cb-4d98-929c-111512e15183"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("83a00c23-aa2c-4493-a275-4e89ed37e063"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("85c79c34-0090-45c7-a50c-f6bbcd79a188"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8d0b2bbd-61d9-491a-a9ab-3378a036488f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("92554e8a-074b-41a3-822e-15daa01f2270"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a6700cb7-a340-4e19-887f-db5ac7eaf375"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a73e7c3e-cfca-4278-a0ea-5302d37abe43"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ac9394d2-0bfa-42fe-a021-9ccdf7c63d19"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ad9223b4-bc9e-422e-ab7f-c8508f1eff4b"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ae261741-e74a-4624-baaf-074734ed182c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("bc01372b-d851-4bd1-a72c-d51f447d35a3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("bc0c105a-1627-4292-84f6-f76b64038ddb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("bccefd26-9e26-4ac4-aa31-34ff2a5361e0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c76845a1-4ab1-4864-a693-9c9a42cbb12a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c85a0404-1649-40e1-ba94-dc36a7f9d184"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("cf33b3c8-6b09-4856-be2d-92e29d991b63"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d8fc8c57-fa1b-43aa-93e9-d49947009ebd"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e446ed35-0512-457e-add6-ea0c21f31a6d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e7036b35-f07f-4e64-8f86-8392be3e4f4c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("eed31ac7-d56c-49c9-9668-066c059655ab"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ef9532c6-e301-4ee2-ad07-5a80b3894346"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f39b38b9-d732-44e8-a0a2-9ab0fae77000"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("fc5b1fd2-1a5f-4736-8fed-a02948efe102"));

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000005") });

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000001"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000005") });

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000002"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000003"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000006") });

            migrationBuilder.DeleteData(
                table: "PermissionUser",
                keyColumns: new[] { "PermissionsId", "UsersId" },
                keyValues: new object[] { new Guid("00000000-0000-0000-0000-000000000004"), new Guid("00000000-0000-0000-0000-000000000007") });

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("00bbbd24-b99b-4f14-8ff2-75d8a5d9c801"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("2d5eef61-d6a9-46de-ad55-673d60917113"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("36d780c1-959f-4480-8698-ea91e273065b"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("54e23e5f-c2d2-4bb5-82fa-176a7db9972f"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("736d1928-a0e7-4c1c-b4de-a2be70408178"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("8146a091-1fc3-4d87-90d7-43b97151e834"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b1616c2e-e72a-4ca8-a133-3c9175692361"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b8cefcd3-99e0-4849-8062-48f891f99fb2"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b9aab22c-e2ff-47f7-8860-c44466757053"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c7290798-7d9f-494d-8ddc-c3efc0c79d04"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d4de14da-e0eb-4188-b942-305f988c29b7"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d7f935c4-278b-4f95-b802-73543433f659"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("e071a88e-b79e-4c1a-ad59-b2dde43204a5"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("f9d2b92b-6caa-4c0f-992e-f5d9fe2afc80"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Permissions",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: new Guid("414a1234-e5cb-4ddc-b821-7393557ed8c3"));
        }
    }
}
