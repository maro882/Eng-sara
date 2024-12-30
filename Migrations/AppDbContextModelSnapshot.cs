﻿// <auto-generated />
using System;
using MarwanMamdohW2_0523016.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarwanMamdohW2_0523016.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarwanMamdohW2_0523016.Models.Entites.Project", b =>
                {
                    b.Property<int>("Projectid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Projectid"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("Startdate")
                        .HasColumnType("datetime2");

                    b.HasKey("Projectid");

                    b.ToTable("projects");
                });

            modelBuilder.Entity("MarwanMamdohW2_0523016.Models.Entites.TeamMember", b =>
                {
                    b.Property<int>("TeamMemberid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeamMemberid"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("TeamMemberid");

                    b.ToTable("teamMembers");
                });

            modelBuilder.Entity("MarwanMamdohW2_0523016.Models.Entites.task", b =>
                {
                    b.Property<int>("taskid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("taskid"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Prirority")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("memid")
                        .HasColumnType("int");

                    b.Property<int>("pid")
                        .HasColumnType("int");

                    b.HasKey("taskid");

                    b.HasIndex("memid");

                    b.HasIndex("pid");

                    b.ToTable("tasks");
                });

            modelBuilder.Entity("MarwanMamdohW2_0523016.Models.Entites.task", b =>
                {
                    b.HasOne("MarwanMamdohW2_0523016.Models.Entites.TeamMember", "member")
                        .WithMany("tasks")
                        .HasForeignKey("memid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MarwanMamdohW2_0523016.Models.Entites.Project", "Project")
                        .WithMany("tasks")
                        .HasForeignKey("pid")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("member");
                });

            modelBuilder.Entity("MarwanMamdohW2_0523016.Models.Entites.Project", b =>
                {
                    b.Navigation("tasks");
                });

            modelBuilder.Entity("MarwanMamdohW2_0523016.Models.Entites.TeamMember", b =>
                {
                    b.Navigation("tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
