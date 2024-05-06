using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ezac.Roster.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class changedJobRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DayPeriodJob");

            migrationBuilder.DropTable(
                name: "JobUser");

            migrationBuilder.AddColumn<Guid>(
                name: "DayPeriodId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Jobs",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_DayPeriodId",
                table: "Jobs",
                column: "DayPeriodId");

            migrationBuilder.CreateIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Jobs_DayPeriods_DayPeriodId",
                table: "Jobs",
                column: "DayPeriodId",
                principalTable: "DayPeriods",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_DayPeriods_DayPeriodId",
                table: "Jobs");

            migrationBuilder.DropForeignKey(
                name: "FK_Jobs_Users_UserId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_DayPeriodId",
                table: "Jobs");

            migrationBuilder.DropIndex(
                name: "IX_Jobs_UserId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "DayPeriodId",
                table: "Jobs");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Jobs");

            migrationBuilder.CreateTable(
                name: "DayPeriodJob",
                columns: table => new
                {
                    DayperiodsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    JobsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DayPeriodJob", x => new { x.DayperiodsId, x.JobsId });
                    table.ForeignKey(
                        name: "FK_DayPeriodJob_DayPeriods_DayperiodsId",
                        column: x => x.DayperiodsId,
                        principalTable: "DayPeriods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DayPeriodJob_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobUser",
                columns: table => new
                {
                    JobsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobUser", x => new { x.JobsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_JobUser_Jobs_JobsId",
                        column: x => x.JobsId,
                        principalTable: "Jobs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JobUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DayPeriodJob_JobsId",
                table: "DayPeriodJob",
                column: "JobsId");

            migrationBuilder.CreateIndex(
                name: "IX_JobUser_UsersId",
                table: "JobUser",
                column: "UsersId");
        }
    }
}
