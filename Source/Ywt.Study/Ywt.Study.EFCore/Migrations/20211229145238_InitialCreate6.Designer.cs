﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Ywt.Study.EFCore;

namespace Ywt.Study.EFCore.Migrations
{
    [DbContext(typeof(StudyDbContext))]
    [Migration("20211229145238_InitialCreate6")]
    partial class InitialCreate6
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ywt.Study.EFCore.Goods", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Goods");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<double>("Height")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("state")
                        .HasColumnType("int");

                    b.Property<double>("weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.TestA", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field11")
                        .HasColumnType("nvarchar(max)")
                        .HasComment("这是一个测试列");

                    b.Property<string>("Field12")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field13")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field14")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field15")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Field2_1");

                    b.Property<string>("Field3")
                        .HasColumnType("varchar(200)");

                    b.Property<decimal>("Field4")
                        .HasColumnType("decimal(5,2)");

                    b.Property<string>("Field5")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<byte[]>("Field6")
                        .HasMaxLength(500)
                        .HasColumnType("varbinary(500)");

                    b.Property<decimal>("Field7")
                        .HasPrecision(14, 2)
                        .HasColumnType("decimal(14,2)");

                    b.Property<DateTime>("Field8")
                        .HasPrecision(3)
                        .HasColumnType("datetime2(3)");

                    b.Property<string>("Field9")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestA");

                    b
                        .HasComment("测试表A");
                });
#pragma warning restore 612, 618
        }
    }
}
