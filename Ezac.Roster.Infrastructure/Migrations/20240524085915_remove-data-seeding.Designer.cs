﻿// <auto-generated />
using System;
using Ezac.Roster.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ezac.Roster.Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240524085915_remove-data-seeding")]
    partial class removedataseeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.ApplicationCalendar", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Day", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CalendarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.DayPeriod", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("End")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Start")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("DayPeriods");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("DayPeriodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PermissionName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("DayPeriodId");

                    b.HasIndex("UserId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Permission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Preference", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Available")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DayId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("DayPeriodId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("JobId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.HasIndex("DayPeriodId");

                    b.HasIndex("JobId");

                    b.HasIndex("UserId");

                    b.ToTable("Preference");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ApplicationCalendarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CalendarId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OriginalId")
                        .HasColumnType("int");

                    b.Property<double>("Scaling")
                        .HasColumnType("float");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationCalendarId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.UserPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Deleted")
                        .HasColumnType("datetime2");

                    b.Property<int>("Experience")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("PermissionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Updated")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Day", b =>
                {
                    b.HasOne("Ezac.Roster.Domain.Entities.ApplicationCalendar", "Calendar")
                        .WithMany("Days")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.DayPeriod", b =>
                {
                    b.HasOne("Ezac.Roster.Domain.Entities.Day", "Day")
                        .WithMany("DayPeriods")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Job", b =>
                {
                    b.HasOne("Ezac.Roster.Domain.Entities.DayPeriod", "DayPeriod")
                        .WithMany("Jobs")
                        .HasForeignKey("DayPeriodId");

                    b.HasOne("Ezac.Roster.Domain.Entities.User", "User")
                        .WithMany("Jobs")
                        .HasForeignKey("UserId");

                    b.Navigation("DayPeriod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Preference", b =>
                {
                    b.HasOne("Ezac.Roster.Domain.Entities.Day", "Day")
                        .WithMany("Preferences")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ezac.Roster.Domain.Entities.DayPeriod", "DayPeriod")
                        .WithMany("Preferences")
                        .HasForeignKey("DayPeriodId");

                    b.HasOne("Ezac.Roster.Domain.Entities.Job", "Job")
                        .WithMany("Preferences")
                        .HasForeignKey("JobId");

                    b.HasOne("Ezac.Roster.Domain.Entities.User", "User")
                        .WithMany("Preferences")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Day");

                    b.Navigation("DayPeriod");

                    b.Navigation("Job");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.User", b =>
                {
                    b.HasOne("Ezac.Roster.Domain.Entities.ApplicationCalendar", "ApplicationCalendar")
                        .WithMany("Users")
                        .HasForeignKey("ApplicationCalendarId");

                    b.Navigation("ApplicationCalendar");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.UserPermission", b =>
                {
                    b.HasOne("Ezac.Roster.Domain.Entities.Permission", "Permission")
                        .WithMany("UserPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ezac.Roster.Domain.Entities.User", "User")
                        .WithMany("UserPermissions")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.ApplicationCalendar", b =>
                {
                    b.Navigation("Days");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Day", b =>
                {
                    b.Navigation("DayPeriods");

                    b.Navigation("Preferences");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.DayPeriod", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Preferences");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Job", b =>
                {
                    b.Navigation("Preferences");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.Permission", b =>
                {
                    b.Navigation("UserPermissions");
                });

            modelBuilder.Entity("Ezac.Roster.Domain.Entities.User", b =>
                {
                    b.Navigation("Jobs");

                    b.Navigation("Preferences");

                    b.Navigation("UserPermissions");
                });
#pragma warning restore 612, 618
        }
    }
}
