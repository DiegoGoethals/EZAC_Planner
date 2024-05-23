using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ezac.Roster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class usercalendar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendars",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Scaling = table.Column<double>(type: "float", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CalendarId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Days_Calendars_CalendarId",
                        column: x => x.CalendarId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationCalendarUser",
                columns: table => new
                {
                    ApplicationCalendarsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationCalendarUser", x => new { x.ApplicationCalendarsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ApplicationCalendarUser_Calendars_ApplicationCalendarsId",
                        column: x => x.ApplicationCalendarsId,
                        principalTable: "Calendars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ApplicationCalendarUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPermissions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PermissionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPermissions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserPermissions_Permissions_PermissionId",
                        column: x => x.PermissionId,
                        principalTable: "Permissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPermissions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DayPeriods",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    Start = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayPeriods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DayPeriods_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DayPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PermissionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jobs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jobs_DayPeriods_DayPeriodId",
                        column: x => x.DayPeriodId,
                        principalTable: "DayPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Jobs_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Preference",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Available = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DayPeriodId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DayId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deleted = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Preference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Preference_DayPeriods_DayPeriodId",
                        column: x => x.DayPeriodId,
                        principalTable: "DayPeriods",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preference_Days_DayId",
                        column: x => x.DayId,
                        principalTable: "Days",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Preference_Jobs_JobId",
                        column: x => x.JobId,
                        principalTable: "Jobs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Preference_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6299), "Zweefvliegkalender", new DateTime(2024, 5, 23, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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
                    { new Guid("00000000-0000-0000-0000-000000000007"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin@ezac.com", true, "Mohammed Ali", 1.0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
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
                    { new Guid("1105e5f1-a97f-48e5-8361-1c2365a2f401"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1112e994-bc14-44c1-a3f7-03d782fdac7c"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17cdaf3f-b4df-4d56-bf18-88e6229bc182"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("34856a0b-550e-446c-b84b-758eda38795f"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("45521cdc-c0bd-46b6-a3fe-b5f18b126392"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b04072b-a5bf-4c62-a188-11204dade305"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6d326957-4b3a-4f15-bef0-6fd28d2a86f7"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("725c1833-d906-47ec-90ef-6f313165822b"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81b773a8-cdc6-48b9-8f49-403bd31f24e8"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a76173a5-6036-4e82-afeb-98f592123d17"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c3e0de1b-da39-4e6c-97c0-8ddcb9c1907c"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d188ba08-1115-4a14-827b-9c16db474e61"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d9a80bd1-acfa-4fa4-ae9d-051a238a9d0d"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6149a16-876b-4fbb-8240-a20614c0fd1b"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e64d0e2b-827b-4132-87b0-f037001fb3b1"), new Guid("ad26e9ce-add9-496a-90ec-1ba1d468af9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 10, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "Created", "Deleted", "Experience", "Name", "PermissionId", "Updated", "UserId" },
                values: new object[,]
                {
                    { new Guid("054c4690-7296-4e8c-aa5f-c2d0a54ce4c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("0aaf5d73-1a04-4dee-a5fd-9a19396c309d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("0d614945-cc8d-4fd3-b9c8-2d9a65a3c44b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("0fbb30a8-e0ee-4454-875d-da20bf9af0c2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("20b36ec9-b397-40fc-8242-b1159f47cf1e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("24fe07a3-4476-411f-a42e-e8f72abe1c2c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("346f591f-5e6f-40c5-b05a-0d54c7064068"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("48b9f3ba-3e29-4252-a7e8-e3a5230d6d2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("58a4d20e-d04c-4790-8cfb-bda660e6cb94"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("5caace7f-d657-4977-8882-794c7f71a772"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("6063389f-ad59-4009-b65d-92687b974194"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("6929bfb2-f14d-4ac5-bced-ae6a5cb121c0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("6f34e23e-a1b4-4fb8-98a9-968b183b9a3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("73ccb532-a2c5-49c0-bc7b-b0e7058e8cb7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("86d97cd1-1589-4024-a3e2-3f2469c5ed66"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("8f5ffe5f-6e5b-4479-9c82-87df97d47909"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("b709e7c7-0e4d-4c83-8589-6073149223be"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("b75af589-1934-49a1-b8a0-02c557a04a4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("d6cf5637-befe-496a-8ec9-fc3c86d04ab9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("dd56b9c4-b7d2-4c7a-ad1e-10d6ab47cb6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("e4abd73d-74be-4a1f-b458-1a8caf125163"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("ec1c1d5b-28e7-45b0-bef3-9677f6f4044c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("04a9be5d-02e8-421d-a996-f2ff6fa541a4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81b773a8-cdc6-48b9-8f49-403bd31f24e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 30, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0537291d-104b-4ccb-a2f2-c2ab15301a80"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17cdaf3f-b4df-4d56-bf18-88e6229bc182"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 25, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("057a3e48-c02f-4330-b958-ca42c53e8846"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3e0de1b-da39-4e6c-97c0-8ddcb9c1907c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 23, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("09311b49-09c2-4023-ac39-ee80a36d9b0c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3e0de1b-da39-4e6c-97c0-8ddcb9c1907c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 22, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0d5e37f7-d8c6-4969-b7c9-0f16ec7884b9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9a80bd1-acfa-4fa4-ae9d-051a238a9d0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 6, 2, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f49cdf0-0300-4ad9-9102-f3e2b13b71f3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b04072b-a5bf-4c62-a188-11204dade305"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 6, 3, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0f901e2b-69c2-4884-a3b6-bd24155f6466"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d326957-4b3a-4f15-bef0-6fd28d2a86f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 29, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0fe1a063-4f03-4a72-aa2b-e6ed93e7c187"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d188ba08-1115-4a14-827b-9c16db474e61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 26, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1945cafd-2b79-4a55-9e30-50fedc455667"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e6149a16-876b-4fbb-8240-a20614c0fd1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 6, 4, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1aa389b0-d5ec-4407-be12-73d5c4c87d6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17cdaf3f-b4df-4d56-bf18-88e6229bc182"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 25, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1ad5a59e-c16c-4a75-a117-19da3729c71b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a76173a5-6036-4e82-afeb-98f592123d17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 28, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1f45a97c-429b-445c-a07c-78257cd03fd4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d188ba08-1115-4a14-827b-9c16db474e61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 27, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("282e8cc3-2a6a-493c-86ac-502978217453"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e6149a16-876b-4fbb-8240-a20614c0fd1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 6, 5, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2bec6715-d360-4b46-bfdf-d1c0fbbded8e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("17cdaf3f-b4df-4d56-bf18-88e6229bc182"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 26, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("363d7214-2f2f-492a-9293-20a4c6b18839"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1112e994-bc14-44c1-a3f7-03d782fdac7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 6, 1, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3742d091-ea0a-4f7f-82f4-9f5357b9792d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81b773a8-cdc6-48b9-8f49-403bd31f24e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 31, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("397aaec1-11aa-4089-b49d-d5f2e235e2ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("81b773a8-cdc6-48b9-8f49-403bd31f24e8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 30, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3df6a870-877b-4559-9d0c-4c05089bc759"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34856a0b-550e-446c-b84b-758eda38795f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 6, 5, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("481a927d-66b4-42d4-abb8-038816dc8a6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34856a0b-550e-446c-b84b-758eda38795f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 6, 6, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b445e34-835a-423f-990d-5598ea2615c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b04072b-a5bf-4c62-a188-11204dade305"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 6, 4, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("50e94c77-45d4-4a64-9783-397e0b24e4a2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1105e5f1-a97f-48e5-8361-1c2365a2f401"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 24, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("510ec51f-ba28-40c3-b76d-8fc2906b34c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45521cdc-c0bd-46b6-a3fe-b5f18b126392"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 6, 2, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("53d70b98-7e91-45cb-b863-17c4aafa26b2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45521cdc-c0bd-46b6-a3fe-b5f18b126392"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 6, 1, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("63a17f3c-0f60-45ac-bfa9-a913498a0d93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d326957-4b3a-4f15-bef0-6fd28d2a86f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 30, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6b69543c-d313-468f-9f68-b80e794ad385"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a76173a5-6036-4e82-afeb-98f592123d17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 27, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a5f6b8c-0be1-4512-9491-8edd38f62870"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1112e994-bc14-44c1-a3f7-03d782fdac7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 31, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7e40236f-f5f9-4c99-8fa6-51aa3131d10a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("34856a0b-550e-446c-b84b-758eda38795f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 6, 5, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("81886b28-badb-418c-bd6e-736cd72ef28f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("725c1833-d906-47ec-90ef-6f313165822b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 28, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8852116a-a109-4fd4-ad12-135ec7e29fde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1105e5f1-a97f-48e5-8361-1c2365a2f401"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 25, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("88f5bb43-3e88-498e-90d3-c7bdd00b0ae4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1112e994-bc14-44c1-a3f7-03d782fdac7c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 31, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8b136fc8-f3e1-4f2d-a409-399c988e738c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d188ba08-1115-4a14-827b-9c16db474e61"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 26, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c882991-f6ff-447c-9aef-3f6d8b211256"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9a80bd1-acfa-4fa4-ae9d-051a238a9d0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 6, 2, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9cec4d56-c95a-4de7-a28b-3962415cdcc3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b04072b-a5bf-4c62-a188-11204dade305"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 6, 3, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a0518765-02b0-45aa-9b23-398863591c8d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("6d326957-4b3a-4f15-bef0-6fd28d2a86f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 29, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a9dddd0d-3006-4350-8731-855aeb88292d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("725c1833-d906-47ec-90ef-6f313165822b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 28, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b28f34dc-c566-4232-98f4-60fe521ea4dd"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("725c1833-d906-47ec-90ef-6f313165822b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 29, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ba1bd0b1-d71c-4885-9584-2685ed6928c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c3e0de1b-da39-4e6c-97c0-8ddcb9c1907c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 22, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c1e89a40-be26-48a9-98da-bfc6993504ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("45521cdc-c0bd-46b6-a3fe-b5f18b126392"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 6, 1, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c2387ed5-a9c7-4066-bce3-b286bbcaccd7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d9a80bd1-acfa-4fa4-ae9d-051a238a9d0d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 6, 3, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cc6f5be2-f992-4857-ba8c-0cd796366105"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e64d0e2b-827b-4132-87b0-f037001fb3b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 9, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "C", new DateTime(2024, 5, 24, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d19a8cce-4411-416e-a0ec-6910ea1f808a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1105e5f1-a97f-48e5-8361-1c2365a2f401"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 24, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d7c721fd-46d0-4dea-b849-42132de95b59"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e64d0e2b-827b-4132-87b0-f037001fb3b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 5, 23, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5e06c5c-b5b1-433b-acde-ccf2b72de4ec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e6149a16-876b-4fbb-8240-a20614c0fd1b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 3, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "B", new DateTime(2024, 6, 4, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fddcc3e4-490c-43c9-a4bf-ae7aee545702"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a76173a5-6036-4e82-afeb-98f592123d17"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 27, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ff434436-d735-46b1-8dbb-89c7629a3409"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e64d0e2b-827b-4132-87b0-f037001fb3b1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 23, 1, 16, 377, DateTimeKind.Local).AddTicks(6252), true, "A", new DateTime(2024, 5, 23, 18, 31, 16, 377, DateTimeKind.Local).AddTicks(6252), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationCalendarUser_UsersId",
                table: "ApplicationCalendarUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_DayPeriods_DayId",
                table: "DayPeriods",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Days_CalendarId",
                table: "Days",
                column: "CalendarId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_DayPeriodId",
                table: "Jobs",
                column: "DayPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Preference_DayId",
                table: "Preference",
                column: "DayId");

            migrationBuilder.CreateIndex(
                name: "IX_Preference_DayPeriodId",
                table: "Preference",
                column: "DayPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Preference_JobId",
                table: "Preference",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_Preference_UserId",
                table: "Preference",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermissions_PermissionId",
                table: "UserPermissions",
                column: "PermissionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPermissions_UserId",
                table: "UserPermissions",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationCalendarUser");

            migrationBuilder.DropTable(
                name: "Preference");

            migrationBuilder.DropTable(
                name: "UserPermissions");

            migrationBuilder.DropTable(
                name: "Jobs");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "DayPeriods");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropTable(
                name: "Calendars");
        }
    }
}
