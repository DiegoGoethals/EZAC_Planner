using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ezac.Roster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateusercalendarrealation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationCalendarUser");

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("08c5c289-9057-4f2a-a611-f080938149d4"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0e0ffd57-ed4d-4244-a8d5-72aed37e6fee"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0eb236e1-201a-4bd6-9cdf-c1f2ccad00d9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("10da7ff0-85cb-476d-a8ba-195ac5dd865a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1d61629d-c458-4db4-ab07-e1d41843f81c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("22efb63e-b894-47be-81f7-2a4b8de45986"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("245fb1b9-130f-4017-afc0-2ec1b2f36401"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2d8c1a47-1386-479e-8903-dd4a41ca27ef"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("300e13e8-edd1-4551-ac33-79920fd511ad"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("3013083d-cc6d-4788-a1b5-2537483aedc4"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("369660d0-aac9-4d27-97e9-adef4c7b2f41"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("3f7f25f8-e72a-4c90-a9d0-d9ab7a773bcb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("448cf5d3-d9cb-400a-be51-3f81b8ae011e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("49947264-bc81-4219-a46a-6f6299ba982e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("528a4866-fc81-4f11-ab47-14fec148af7a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("583d58a9-0c92-42ba-bb8a-7aacbff659c6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("5848dec4-87ed-403a-adb8-2928f3a4ed25"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6ea63300-1cb5-42dc-b25b-6a1e44c4e868"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6eb7e8f9-856e-4f2a-bb89-5357279a58f6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("721f8e36-6f53-40c4-a73c-c5b56f239a99"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("75683a0c-67ce-4626-b6de-57316de7a6fb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("75d45b33-7262-46df-88b8-612af09fd713"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7715d401-f348-4405-809f-1e9415c0e632"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("77198afe-d9e6-40a7-be47-39362649b1b6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7ae75f8c-ed23-48a8-8385-4c43489b93cc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("811e5b47-3d2b-472b-a619-87655e59d5d8"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("86290f28-e939-49a6-a587-5ae1cc06db29"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8f481e32-3dc4-4438-9c8f-630f819c966a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("979be1ad-9dca-43e0-980a-0d897d53d032"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("9a2fa4ef-38d0-401e-8697-3026e50d2aa3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("9c148b90-cd15-4a9d-954b-aafa91b8ca9d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a396d09f-2e96-4103-b8e3-e2b57046a061"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ad5dc8fc-0e14-49a2-b6d9-053a7986643e"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("b2372e1c-9de7-48d9-966d-63dd8d0dc567"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c686df53-0c85-406d-9563-7b9bdf8cc644"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d00c5fab-1d43-4c25-974c-28fd0f8e6245"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e05366a0-f870-4a11-8716-c6e0961d9bec"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e1352eb2-715a-4dd5-9224-e2562023e614"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e1fb2db9-1874-4139-bc49-850fce66baf6"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ef09e0f8-3272-48b5-a357-29ea03416d8c"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f5fd82ba-2418-446b-b18c-2cade53c64d5"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f792f75b-075e-4efb-9916-9d7cdc34bb6d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f7ea5210-95a5-4e79-a411-12db7354dfb0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f9fdd21a-7158-4af6-b558-b7cb89683ee0"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("fb82a5b6-629c-4b8c-870b-ad1950a9614f"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("05c2b782-459a-4586-9e96-89bb06c49b3d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("086e6712-6aed-4750-ab8c-01a9ee182a2d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("08742d6d-92a0-43a1-9cc3-2eea0692986b"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("289d836f-c795-4ad7-99c9-e2680bb997d1"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("338cbe03-1a73-4602-ae5d-d971f6963562"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3c17d171-8e3b-4d62-867f-60dc804b0026"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("5560051c-f5f3-4aa5-8c8f-0aafbbb67f96"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("59ae60d3-19af-4c36-a7b5-3ee4802795d1"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("78cb03de-2ae2-49d8-9df7-fd9e01cf4302"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("79e5fc4f-5cf3-45b5-b3f5-5e8f052b32d1"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("86da7d1a-9a21-4ffb-a01d-dca37acb8f93"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("9271fd45-71b6-4391-84cd-5ec5a72ae15d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b3c96cc5-8a2a-4cb2-9310-4b0486d35b82"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b539c859-3520-40e6-bf21-477e632e982f"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("be021784-a4b4-46e9-ba81-f272884b4bc9"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("beb84793-9b77-4d99-8ac2-36005021e28a"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c1479a72-3dc2-4ebb-a109-f1ba46c7a922"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("d2590645-3d5d-4fda-adee-ccf1ed6d8f67"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("eea86202-52cf-4151-baef-32576c97e2b5"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("ef63a6da-8249-442c-89c4-1086c3682afc"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f80eac43-92f2-4c72-bdc6-dd655f188cd0"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("fcfae561-2759-4448-87f6-09554f98b960"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("0fce4dda-d5fd-4e7e-9064-d350fd62d7f7"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("1a63b13d-34a4-44ba-8daf-1b03550027ae"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("4b958f0e-deea-4f70-8ff2-fa6cbe9d46c7"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("5efa091c-1ed1-4ce1-98ee-18cb049a210e"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("758ba8d0-c43f-4d36-baac-c342f733e5af"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("78db8a6c-bffe-4998-b214-97cc5daed0a3"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("7ee19617-d865-4db7-84b0-4f31be598e2f"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("844fde77-902a-4975-93f8-119b2a8416f2"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("92f31960-fde6-4fc4-abe6-9d29a99a4b43"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("97ae2d84-1af4-4868-be59-02cb4ac4e0a8"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("998d9836-8dc7-489e-bbcb-29e85a559037"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("b8a5f2ec-542e-4e07-9bcc-8e815f2abb8b"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c38c4f7d-f0ab-4339-8c59-c58246eade24"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("c42c7c2e-5476-4af9-be3f-4609a7635888"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("ce7efe55-988a-442d-957b-65a307158336"));

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"));

            migrationBuilder.AddColumn<Guid>(
                name: "ApplicationCalendarId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2918), "Zweefvliegkalender", new DateTime(2024, 5, 23, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "Created", "Deleted", "Experience", "Name", "PermissionId", "Updated", "UserId" },
                values: new object[,]
                {
                    { new Guid("012f52e9-5bfd-4d8d-adcf-c65f137f6ea9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("137af9ee-5faf-4e75-9b26-e753fa658176"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("13ef4064-620d-4030-b5a0-1e0637eb13e5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("20cb8a92-aab1-4720-9070-481acf01ba9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("349abb5a-a87e-46e8-a540-2f2c33f063cf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("3a936098-db99-49d5-9aac-0b7e020fe9ff"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("4bedf104-6e3e-42ff-ad25-69a65abf542d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("60e2ad9f-44cd-41e5-9c9e-cbe8ec3537e2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("775390ce-73e2-4128-b1a7-42d8c5040cdf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("9783ec6b-eddc-4e1d-a784-6d3d0105382e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("a0d81f3f-c9e9-43ef-8f52-3cf9cc2bf207"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("a308a0fe-cca1-4fe7-b079-6d6c7ade7a54"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("a8a7adae-b404-4334-8aac-49f3a0e866ba"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("b26945ee-e428-4456-b17c-f54b6ecd274e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("b56a1092-7727-4784-8239-85297f53797d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("b8e12b0e-0d75-4864-b87c-c1aff7239e07"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("c1c99fe5-b7cd-43b0-9631-fca7309f921d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("c747f09c-f50f-4e0a-9fea-76ccd7a89e3b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("cb0ea815-f4c4-45ae-b09b-6b811cff494a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("f0b785e6-b389-440e-bda6-1e8ecd6d0cde"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("f34fe1d2-003c-4870-a2c9-07b20006f499"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("f9f425ae-d712-4cb2-9d69-bd5da087f174"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000005"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000006"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000007"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000008"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000009"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000010"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000011"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000012"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("00000000-0000-0000-0000-000000000013"),
                column: "ApplicationCalendarId",
                value: null);

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "CalendarId", "Created", "Date", "Deleted", "IsOpen", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("0b3708ab-b9ec-4b5e-90f5-f00defad2f84"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("266c22aa-e0a7-4cbf-b03e-b7fd7e14043a"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4e802fe9-e8d9-464b-8aa5-47b257cfa827"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5531b5bb-0284-49ca-8a1e-88da8a894ba9"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("571c7c86-e9ce-459a-986e-4999a2462555"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("74390deb-9c73-4acb-9744-a4f9dad7c0f0"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7640c9ac-6636-44da-b6b6-19dc048789e4"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7a5554f3-7e11-4af1-8713-c69587da481a"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8e130ebf-489d-4aca-bc8f-37796837f32c"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bc65a03c-49c1-453d-84c4-fccb07031e39"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d345137d-d589-4343-81d1-4fe259cfbb48"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("dd8b2178-b280-4cb5-a850-7056e5a2b471"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ecdec4ec-d7b1-45ba-ac79-37965b4d2e01"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef3cf44b-0028-4187-920c-98f141378ea5"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f6792bbf-30e0-4294-af7a-25fab9c6a029"), new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 13, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("0364880a-f2c9-4bb2-afc5-ec3a27b039a9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc65a03c-49c1-453d-84c4-fccb07031e39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 28, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("17c8a081-6738-43ef-bf2e-4bac29250115"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd8b2178-b280-4cb5-a850-7056e5a2b471"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 30, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a05fdc5-d05b-4a8a-b070-8978b369d560"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7a5554f3-7e11-4af1-8713-c69587da481a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 24, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1b190fb5-2c61-41ff-97ea-7a1fbc8544e3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d345137d-d589-4343-81d1-4fe259cfbb48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 22, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d475074-d5bb-4567-84ab-648feaa8d578"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b3708ab-b9ec-4b5e-90f5-f00defad2f84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 6, 1, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2b6b58eb-870f-450b-a384-808e3a587c84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e802fe9-e8d9-464b-8aa5-47b257cfa827"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 27, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("31f7c2ec-ce15-48a7-99c7-ad04baa06935"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e802fe9-e8d9-464b-8aa5-47b257cfa827"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 27, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4134c504-27ec-45dd-b4ce-740558801559"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("571c7c86-e9ce-459a-986e-4999a2462555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 6, 4, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4f5eaa65-5dd9-4184-956b-60de64bcacd9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74390deb-9c73-4acb-9744-a4f9dad7c0f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 31, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("58901b21-9044-48bb-81b0-9b3558deb946"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef3cf44b-0028-4187-920c-98f141378ea5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 6, 2, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5e63e4de-d66e-4806-8722-22b3fc1c4ebc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ecdec4ec-d7b1-45ba-ac79-37965b4d2e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 25, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6dc13acb-d224-4896-ba1c-4056a1ceeee7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6792bbf-30e0-4294-af7a-25fab9c6a029"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 6, 6, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("744dbfdd-d650-43ad-8223-a4f96f081b2a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("571c7c86-e9ce-459a-986e-4999a2462555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 6, 5, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75540484-c1e4-4734-86fe-387ef3d9f5a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5531b5bb-0284-49ca-8a1e-88da8a894ba9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 25, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("778c7041-f529-49f4-8fbf-6c43a7d0ee6f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640c9ac-6636-44da-b6b6-19dc048789e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 29, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("79b09b7c-3ef6-4cca-8a50-c7a114108893"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d345137d-d589-4343-81d1-4fe259cfbb48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 23, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7b3f060a-4041-4e4d-9cbc-da47ec21d4ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8e130ebf-489d-4aca-bc8f-37796837f32c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 6, 2, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7de0aefe-958f-4558-b99d-d561a46f70c3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640c9ac-6636-44da-b6b6-19dc048789e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 28, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("809b67ee-ebf7-4c7a-b3a3-ffe4cad09b6b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef3cf44b-0028-4187-920c-98f141378ea5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 6, 1, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("860fdc12-5190-4c8f-9808-cc67e4d4a6e9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6792bbf-30e0-4294-af7a-25fab9c6a029"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 6, 5, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8a0e9245-2476-40b8-bdc3-bde7952c1e4a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f6792bbf-30e0-4294-af7a-25fab9c6a029"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 6, 6, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("95ccae5b-a06a-4d84-abfc-c08349188bae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5531b5bb-0284-49ca-8a1e-88da8a894ba9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 26, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9eea9ab6-faa8-40e2-b350-f28f69d37aa1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74390deb-9c73-4acb-9744-a4f9dad7c0f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 30, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a1426b68-e6ac-46ba-a833-a166ceb372ea"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4e802fe9-e8d9-464b-8aa5-47b257cfa827"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 26, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a8604965-4cad-4874-8763-d6fc5a605e27"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b3708ab-b9ec-4b5e-90f5-f00defad2f84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 31, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a95b0b50-cce4-4cc1-865c-35a0e96d3922"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc65a03c-49c1-453d-84c4-fccb07031e39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 28, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("abf8c186-e174-4fc8-b88a-9088a4ccf8d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7a5554f3-7e11-4af1-8713-c69587da481a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 23, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ac7b5293-591f-447d-b8f7-da9a61ab63fa"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("266c22aa-e0a7-4cbf-b03e-b7fd7e14043a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 6, 4, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("af03745a-4acc-42c4-806f-018699ead65f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("266c22aa-e0a7-4cbf-b03e-b7fd7e14043a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 6, 3, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("bf599969-290d-417a-ade5-ea01541bd208"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8e130ebf-489d-4aca-bc8f-37796837f32c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 6, 3, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c44263fb-1e9b-4b62-8d61-a900f543dfbe"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0b3708ab-b9ec-4b5e-90f5-f00defad2f84"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 6, 1, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c516b679-17bc-43be-8212-d5e7e2bbafaf"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd8b2178-b280-4cb5-a850-7056e5a2b471"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 30, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("cefab9d1-09c2-4292-9bb8-921d295a9252"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("74390deb-9c73-4acb-9744-a4f9dad7c0f0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 31, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d22c1fb7-e767-4593-b28e-6582acf89ff8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("571c7c86-e9ce-459a-986e-4999a2462555"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 6, 5, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e2e1e53a-a240-484d-bdfa-be73129efa6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ef3cf44b-0028-4187-920c-98f141378ea5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 6, 2, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e32517de-4ba0-4e98-bcea-c1a486b80f71"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5531b5bb-0284-49ca-8a1e-88da8a894ba9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 26, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e68dfeac-c19f-4759-9d8d-a8cceb5ae4a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7640c9ac-6636-44da-b6b6-19dc048789e4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 29, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e6eb0eca-d46b-449a-8fdb-2dcda57e65bb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d345137d-d589-4343-81d1-4fe259cfbb48"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 23, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eb091ebc-3ed9-47f7-a078-7ea9e0825be2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("266c22aa-e0a7-4cbf-b03e-b7fd7e14043a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 6, 4, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee0d238b-e18a-47e8-b330-bfa85b70ccef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ecdec4ec-d7b1-45ba-ac79-37965b4d2e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 24, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ee8d46d2-dfb0-49de-9106-c19b94ba5fa9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("8e130ebf-489d-4aca-bc8f-37796837f32c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 6, 3, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("eef6486c-4444-465c-b464-b9eabb1b4f88"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("bc65a03c-49c1-453d-84c4-fccb07031e39"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 27, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f16ceb9b-db63-4356-92bd-4a9c06b8e6f1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ecdec4ec-d7b1-45ba-ac79-37965b4d2e01"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "B", new DateTime(2024, 5, 25, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f23caaf8-b209-4e1e-a93f-9e1eb4c2f095"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7a5554f3-7e11-4af1-8713-c69587da481a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 12, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "C", new DateTime(2024, 5, 24, 6, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f256b613-6f19-4167-9a98-801edefe397f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("dd8b2178-b280-4cb5-a850-7056e5a2b471"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 2, 11, 47, 112, DateTimeKind.Local).AddTicks(2875), true, "A", new DateTime(2024, 5, 29, 21, 41, 47, 112, DateTimeKind.Local).AddTicks(2875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_ApplicationCalendarId",
                table: "Users",
                column: "ApplicationCalendarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Calendars_ApplicationCalendarId",
                table: "Users",
                column: "ApplicationCalendarId",
                principalTable: "Calendars",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Calendars_ApplicationCalendarId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_ApplicationCalendarId",
                table: "Users");

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("0364880a-f2c9-4bb2-afc5-ec3a27b039a9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("17c8a081-6738-43ef-bf2e-4bac29250115"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1a05fdc5-d05b-4a8a-b070-8978b369d560"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1b190fb5-2c61-41ff-97ea-7a1fbc8544e3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("1d475074-d5bb-4567-84ab-648feaa8d578"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("2b6b58eb-870f-450b-a384-808e3a587c84"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("31f7c2ec-ce15-48a7-99c7-ad04baa06935"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4134c504-27ec-45dd-b4ce-740558801559"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("4f5eaa65-5dd9-4184-956b-60de64bcacd9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("58901b21-9044-48bb-81b0-9b3558deb946"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("5e63e4de-d66e-4806-8722-22b3fc1c4ebc"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("6dc13acb-d224-4896-ba1c-4056a1ceeee7"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("744dbfdd-d650-43ad-8223-a4f96f081b2a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("75540484-c1e4-4734-86fe-387ef3d9f5a3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("778c7041-f529-49f4-8fbf-6c43a7d0ee6f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("79b09b7c-3ef6-4cca-8a50-c7a114108893"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7b3f060a-4041-4e4d-9cbc-da47ec21d4ad"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("7de0aefe-958f-4558-b99d-d561a46f70c3"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("809b67ee-ebf7-4c7a-b3a3-ffe4cad09b6b"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("860fdc12-5190-4c8f-9808-cc67e4d4a6e9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("8a0e9245-2476-40b8-bdc3-bde7952c1e4a"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("95ccae5b-a06a-4d84-abfc-c08349188bae"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("9eea9ab6-faa8-40e2-b350-f28f69d37aa1"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a1426b68-e6ac-46ba-a833-a166ceb372ea"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a8604965-4cad-4874-8763-d6fc5a605e27"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("a95b0b50-cce4-4cc1-865c-35a0e96d3922"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("abf8c186-e174-4fc8-b88a-9088a4ccf8d1"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ac7b5293-591f-447d-b8f7-da9a61ab63fa"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("af03745a-4acc-42c4-806f-018699ead65f"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("bf599969-290d-417a-ade5-ea01541bd208"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c44263fb-1e9b-4b62-8d61-a900f543dfbe"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("c516b679-17bc-43be-8212-d5e7e2bbafaf"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("cefab9d1-09c2-4292-9bb8-921d295a9252"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("d22c1fb7-e767-4593-b28e-6582acf89ff8"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e2e1e53a-a240-484d-bdfa-be73129efa6d"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e32517de-4ba0-4e98-bcea-c1a486b80f71"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e68dfeac-c19f-4759-9d8d-a8cceb5ae4a8"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("e6eb0eca-d46b-449a-8fdb-2dcda57e65bb"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("eb091ebc-3ed9-47f7-a078-7ea9e0825be2"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ee0d238b-e18a-47e8-b330-bfa85b70ccef"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("ee8d46d2-dfb0-49de-9106-c19b94ba5fa9"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("eef6486c-4444-465c-b464-b9eabb1b4f88"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f16ceb9b-db63-4356-92bd-4a9c06b8e6f1"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f23caaf8-b209-4e1e-a93f-9e1eb4c2f095"));

            migrationBuilder.DeleteData(
                table: "DayPeriods",
                keyColumn: "Id",
                keyValue: new Guid("f256b613-6f19-4167-9a98-801edefe397f"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("012f52e9-5bfd-4d8d-adcf-c65f137f6ea9"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("137af9ee-5faf-4e75-9b26-e753fa658176"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("13ef4064-620d-4030-b5a0-1e0637eb13e5"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("20cb8a92-aab1-4720-9070-481acf01ba9b"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("349abb5a-a87e-46e8-a540-2f2c33f063cf"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("3a936098-db99-49d5-9aac-0b7e020fe9ff"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("4bedf104-6e3e-42ff-ad25-69a65abf542d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("60e2ad9f-44cd-41e5-9c9e-cbe8ec3537e2"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("775390ce-73e2-4128-b1a7-42d8c5040cdf"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("9783ec6b-eddc-4e1d-a784-6d3d0105382e"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a0d81f3f-c9e9-43ef-8f52-3cf9cc2bf207"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a308a0fe-cca1-4fe7-b079-6d6c7ade7a54"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("a8a7adae-b404-4334-8aac-49f3a0e866ba"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b26945ee-e428-4456-b17c-f54b6ecd274e"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b56a1092-7727-4784-8239-85297f53797d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("b8e12b0e-0d75-4864-b87c-c1aff7239e07"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c1c99fe5-b7cd-43b0-9631-fca7309f921d"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("c747f09c-f50f-4e0a-9fea-76ccd7a89e3b"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("cb0ea815-f4c4-45ae-b09b-6b811cff494a"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f0b785e6-b389-440e-bda6-1e8ecd6d0cde"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f34fe1d2-003c-4870-a2c9-07b20006f499"));

            migrationBuilder.DeleteData(
                table: "UserPermissions",
                keyColumn: "Id",
                keyValue: new Guid("f9f425ae-d712-4cb2-9d69-bd5da087f174"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("0b3708ab-b9ec-4b5e-90f5-f00defad2f84"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("266c22aa-e0a7-4cbf-b03e-b7fd7e14043a"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("4e802fe9-e8d9-464b-8aa5-47b257cfa827"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("5531b5bb-0284-49ca-8a1e-88da8a894ba9"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("571c7c86-e9ce-459a-986e-4999a2462555"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("74390deb-9c73-4acb-9744-a4f9dad7c0f0"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("7640c9ac-6636-44da-b6b6-19dc048789e4"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("7a5554f3-7e11-4af1-8713-c69587da481a"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("8e130ebf-489d-4aca-bc8f-37796837f32c"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("bc65a03c-49c1-453d-84c4-fccb07031e39"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("d345137d-d589-4343-81d1-4fe259cfbb48"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("dd8b2178-b280-4cb5-a850-7056e5a2b471"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("ecdec4ec-d7b1-45ba-ac79-37965b4d2e01"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("ef3cf44b-0028-4187-920c-98f141378ea5"));

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "Id",
                keyValue: new Guid("f6792bbf-30e0-4294-af7a-25fab9c6a029"));

            migrationBuilder.DeleteData(
                table: "Calendars",
                keyColumn: "Id",
                keyValue: new Guid("181e6f2d-18f0-4900-b7bb-f11ad35617ea"));

            migrationBuilder.DropColumn(
                name: "ApplicationCalendarId",
                table: "Users");

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

            migrationBuilder.InsertData(
                table: "Calendars",
                columns: new[] { "Id", "Created", "Deleted", "End", "Name", "Start", "Updated" },
                values: new object[] { new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1716), "Zweefvliegkalender", new DateTime(2024, 5, 23, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "UserPermissions",
                columns: new[] { "Id", "Created", "Deleted", "Experience", "Name", "PermissionId", "Updated", "UserId" },
                values: new object[,]
                {
                    { new Guid("05c2b782-459a-4586-9e96-89bb06c49b3d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("086e6712-6aed-4750-ab8c-01a9ee182a2d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("08742d6d-92a0-43a1-9cc3-2eea0692986b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("289d836f-c795-4ad7-99c9-e2680bb997d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("338cbe03-1a73-4602-ae5d-d971f6963562"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("3c17d171-8e3b-4d62-867f-60dc804b0026"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("5560051c-f5f3-4aa5-8c8f-0aafbbb67f96"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000011") },
                    { new Guid("59ae60d3-19af-4c36-a7b5-3ee4802795d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("78cb03de-2ae2-49d8-9df7-fd9e01cf4302"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("79e5fc4f-5cf3-45b5-b3f5-5e8f052b32d1"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("86da7d1a-9a21-4ffb-a01d-dca37acb8f93"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("9271fd45-71b6-4391-84cd-5ec5a72ae15d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000005") },
                    { new Guid("b3c96cc5-8a2a-4cb2-9310-4b0486d35b82"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("b539c859-3520-40e6-bf21-477e632e982f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Lierist", new Guid("00000000-0000-0000-0000-000000000001"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000008") },
                    { new Guid("be021784-a4b4-46e9-ba81-f272884b4bc9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("beb84793-9b77-4d99-8ac2-36005021e28a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000007") },
                    { new Guid("c1479a72-3dc2-4ebb-a109-f1ba46c7a922"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000013") },
                    { new Guid("d2590645-3d5d-4fda-adee-ccf1ed6d8f67"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000006") },
                    { new Guid("eea86202-52cf-4151-baef-32576c97e2b5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000009") },
                    { new Guid("ef63a6da-8249-442c-89c4-1086c3682afc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Bardienst", new Guid("00000000-0000-0000-0000-000000000003"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") },
                    { new Guid("f80eac43-92f2-4c72-bdc6-dd655f188cd0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Startofficier", new Guid("00000000-0000-0000-0000-000000000002"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000010") },
                    { new Guid("fcfae561-2759-4448-87f6-09554f98b960"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Instructeur", new Guid("00000000-0000-0000-0000-000000000004"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("00000000-0000-0000-0000-000000000012") }
                });

            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "Id", "CalendarId", "Created", "Date", "Deleted", "IsOpen", "Name", "Updated" },
                values: new object[,]
                {
                    { new Guid("0fce4dda-d5fd-4e7e-9064-d350fd62d7f7"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1a63b13d-34a4-44ba-8daf-1b03550027ae"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("4b958f0e-deea-4f70-8ff2-fa6cbe9d46c7"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5efa091c-1ed1-4ce1-98ee-18cb049a210e"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("758ba8d0-c43f-4d36-baac-c342f733e5af"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("78db8a6c-bffe-4998-b214-97cc5daed0a3"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Tuesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ee19617-d865-4db7-84b0-4f31be598e2f"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("844fde77-902a-4975-93f8-119b2a8416f2"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("92f31960-fde6-4fc4-abe6-9d29a99a4b43"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Wednesday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("97ae2d84-1af4-4868-be59-02cb4ac4e0a8"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("998d9836-8dc7-489e-bbcb-29e85a559037"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Sunday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b8a5f2ec-542e-4e07-9bcc-8e815f2abb8b"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Thursday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c38c4f7d-f0ab-4339-8c59-c58246eade24"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saturday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c42c7c2e-5476-4af9-be3f-4609a7635888"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Friday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ce7efe55-988a-442d-957b-65a307158336"), new Guid("c2b7745e-1099-458e-bb10-06b1f8370a15"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 10, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "Monday", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "DayPeriods",
                columns: new[] { "Id", "Created", "DayId", "Deleted", "End", "IsOpen", "Name", "Start", "Updated" },
                values: new object[,]
                {
                    { new Guid("08c5c289-9057-4f2a-a611-f080938149d4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("998d9836-8dc7-489e-bbcb-29e85a559037"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 27, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0e0ffd57-ed4d-4244-a8d5-72aed37e6fee"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("998d9836-8dc7-489e-bbcb-29e85a559037"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 26, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("0eb236e1-201a-4bd6-9cdf-c1f2ccad00d9"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c42c7c2e-5476-4af9-be3f-4609a7635888"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 25, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10da7ff0-85cb-476d-a8ba-195ac5dd865a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fce4dda-d5fd-4e7e-9064-d350fd62d7f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 6, 6, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1d61629d-c458-4db4-ab07-e1d41843f81c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b958f0e-deea-4f70-8ff2-fa6cbe9d46c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 29, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("22efb63e-b894-47be-81f7-2a4b8de45986"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78db8a6c-bffe-4998-b214-97cc5daed0a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 6, 5, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("245fb1b9-130f-4017-afc0-2ec1b2f36401"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5efa091c-1ed1-4ce1-98ee-18cb049a210e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 6, 4, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("2d8c1a47-1386-479e-8903-dd4a41ca27ef"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("97ae2d84-1af4-4868-be59-02cb4ac4e0a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 6, 3, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("300e13e8-edd1-4551-ac33-79920fd511ad"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ee19617-d865-4db7-84b0-4f31be598e2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 31, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3013083d-cc6d-4788-a1b5-2537483aedc4"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78db8a6c-bffe-4998-b214-97cc5daed0a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 6, 4, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("369660d0-aac9-4d27-97e9-adef4c7b2f41"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1a63b13d-34a4-44ba-8daf-1b03550027ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 23, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("3f7f25f8-e72a-4c90-a9d0-d9ab7a773bcb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("758ba8d0-c43f-4d36-baac-c342f733e5af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 6, 1, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("448cf5d3-d9cb-400a-be51-3f81b8ae011e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("758ba8d0-c43f-4d36-baac-c342f733e5af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 6, 1, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("49947264-bc81-4219-a46a-6f6299ba982e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c38c4f7d-f0ab-4339-8c59-c58246eade24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 26, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("528a4866-fc81-4f11-ab47-14fec148af7a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8a5f2ec-542e-4e07-9bcc-8e815f2abb8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 23, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("583d58a9-0c92-42ba-bb8a-7aacbff659c6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c42c7c2e-5476-4af9-be3f-4609a7635888"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 24, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("5848dec4-87ed-403a-adb8-2928f3a4ed25"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fce4dda-d5fd-4e7e-9064-d350fd62d7f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 6, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 6, 5, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6ea63300-1cb5-42dc-b25b-6a1e44c4e868"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92f31960-fde6-4fc4-abe6-9d29a99a4b43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 29, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("6eb7e8f9-856e-4f2a-bb89-5357279a58f6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ee19617-d865-4db7-84b0-4f31be598e2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 1, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 6, 1, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("721f8e36-6f53-40c4-a73c-c5b56f239a99"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("78db8a6c-bffe-4998-b214-97cc5daed0a3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 6, 4, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75683a0c-67ce-4626-b6de-57316de7a6fb"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("7ee19617-d865-4db7-84b0-4f31be598e2f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 31, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("75d45b33-7262-46df-88b8-612af09fd713"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c38c4f7d-f0ab-4339-8c59-c58246eade24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 25, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7715d401-f348-4405-809f-1e9415c0e632"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92f31960-fde6-4fc4-abe6-9d29a99a4b43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 29, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("77198afe-d9e6-40a7-be47-39362649b1b6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1a63b13d-34a4-44ba-8daf-1b03550027ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 22, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 22, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("7ae75f8c-ed23-48a8-8385-4c43489b93cc"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8a5f2ec-542e-4e07-9bcc-8e815f2abb8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 24, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("811e5b47-3d2b-472b-a619-87655e59d5d8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ce7efe55-988a-442d-957b-65a307158336"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 27, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("86290f28-e939-49a6-a587-5ae1cc06db29"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("97ae2d84-1af4-4868-be59-02cb4ac4e0a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 6, 2, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("8f481e32-3dc4-4438-9c8f-630f819c966a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5efa091c-1ed1-4ce1-98ee-18cb049a210e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 6, 3, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("979be1ad-9dca-43e0-980a-0d897d53d032"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("5efa091c-1ed1-4ce1-98ee-18cb049a210e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 4, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 6, 3, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9a2fa4ef-38d0-401e-8697-3026e50d2aa3"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("844fde77-902a-4975-93f8-119b2a8416f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 30, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("9c148b90-cd15-4a9d-954b-aafa91b8ca9d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c38c4f7d-f0ab-4339-8c59-c58246eade24"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 25, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a396d09f-2e96-4103-b8e3-e2b57046a061"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ce7efe55-988a-442d-957b-65a307158336"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 28, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ad5dc8fc-0e14-49a2-b6d9-053a7986643e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("0fce4dda-d5fd-4e7e-9064-d350fd62d7f7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 5, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 6, 5, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("b2372e1c-9de7-48d9-966d-63dd8d0dc567"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b958f0e-deea-4f70-8ff2-fa6cbe9d46c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 28, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("c686df53-0c85-406d-9563-7b9bdf8cc644"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4b958f0e-deea-4f70-8ff2-fa6cbe9d46c7"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 28, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("d00c5fab-1d43-4c25-974c-28fd0f8e6245"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("758ba8d0-c43f-4d36-baac-c342f733e5af"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 2, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 6, 2, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e05366a0-f870-4a11-8716-c6e0961d9bec"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ce7efe55-988a-442d-957b-65a307158336"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 28, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 27, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1352eb2-715a-4dd5-9224-e2562023e614"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("97ae2d84-1af4-4868-be59-02cb4ac4e0a8"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 6, 3, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 6, 2, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("e1fb2db9-1874-4139-bc49-850fce66baf6"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("92f31960-fde6-4fc4-abe6-9d29a99a4b43"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 30, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("ef09e0f8-3272-48b5-a357-29ea03416d8c"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("844fde77-902a-4975-93f8-119b2a8416f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 30, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 30, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f5fd82ba-2418-446b-b18c-2cade53c64d5"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c42c7c2e-5476-4af9-be3f-4609a7635888"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 24, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f792f75b-075e-4efb-9916-9d7cdc34bb6d"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1a63b13d-34a4-44ba-8daf-1b03550027ae"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 22, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f7ea5210-95a5-4e79-a411-12db7354dfb0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b8a5f2ec-542e-4e07-9bcc-8e815f2abb8b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 23, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "A", new DateTime(2024, 5, 23, 19, 27, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("f9fdd21a-7158-4af6-b558-b7cb89683ee0"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("998d9836-8dc7-489e-bbcb-29e85a559037"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "B", new DateTime(2024, 5, 26, 23, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("fb82a5b6-629c-4b8c-870b-ad1950a9614f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("844fde77-902a-4975-93f8-119b2a8416f2"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 31, 9, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), true, "C", new DateTime(2024, 5, 31, 3, 57, 44, 71, DateTimeKind.Local).AddTicks(1672), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationCalendarUser_UsersId",
                table: "ApplicationCalendarUser",
                column: "UsersId");
        }
    }
}
