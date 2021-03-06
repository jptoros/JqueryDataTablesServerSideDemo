﻿// <auto-generated />
using System;
using AspNetCoreServerSide;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AspNetCoreServerSide.Migrations
{
    [DbContext(typeof(Fingers10DbContext))]
    partial class Fingers10DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspNetCoreServerSide.Models.DemoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DemoNestedLevelOneId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Office")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DemoNestedLevelOneId");

                    b.ToTable("Demos");
                });

            modelBuilder.Entity("AspNetCoreServerSide.Models.DemoNestedLevelOneEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DemoNestedLevelTwoId")
                        .HasColumnType("int");

                    b.Property<short?>("Experience")
                        .HasColumnType("smallint");

                    b.Property<int?>("Extn")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DemoNestedLevelTwoId");

                    b.ToTable("DemoNestedLevelOneEntity");
                });

            modelBuilder.Entity("AspNetCoreServerSide.Models.DemoNestedLevelTwoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Salary")
                        .HasColumnType("bigint");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("DemoNestedLevelTwoEntity");
                });

            modelBuilder.Entity("AspNetCoreServerSide.Models.DemoEntity", b =>
                {
                    b.HasOne("AspNetCoreServerSide.Models.DemoNestedLevelOneEntity", "DemoNestedLevelOne")
                        .WithMany()
                        .HasForeignKey("DemoNestedLevelOneId");
                });

            modelBuilder.Entity("AspNetCoreServerSide.Models.DemoNestedLevelOneEntity", b =>
                {
                    b.HasOne("AspNetCoreServerSide.Models.DemoNestedLevelTwoEntity", "DemoNestedLevelTwo")
                        .WithMany()
                        .HasForeignKey("DemoNestedLevelTwoId");
                });
#pragma warning restore 612, 618
        }
    }
}
