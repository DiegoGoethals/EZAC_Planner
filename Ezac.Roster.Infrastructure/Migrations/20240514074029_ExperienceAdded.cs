using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ezac.Roster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExperienceAdded : Migration
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
                values: new object[] { new Guid("fe6ea702-3c98-4731-903f-31da7623650e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 14, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2498), "Zweefvliegkalender", new DateTime(2024, 5, 14, 9, 40, 29, 218, DateTimeKind.Local).AddTicks(2452), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Jobs",
                columns: new[] { "Id", "Created", "DayPeriodId", "Deleted", "Experience", "Name", "PermissionName", "Updated", "UserId", "Weight" },
                values: new object[,]
                {
                    { new Guid("00000000-0000-0000-0000-000000000008"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lierist", "Lierist", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000009"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Startofficier", "Startofficier", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000010"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", "Bardienst", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000011"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Instructeur", "Instructeur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 },
                    { new Guid("00000000-0000-0000-0000-000000000012"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Instructeur(DDI)", "Instructeur", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0.0 }
                });

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
