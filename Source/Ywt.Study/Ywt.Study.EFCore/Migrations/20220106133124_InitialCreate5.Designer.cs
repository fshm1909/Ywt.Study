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
    [Migration("20220106133124_InitialCreate5")]
    partial class InitialCreate5
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

            modelBuilder.Entity("Ywt.Study.EFCore.R1", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("R1");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.R2", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("R1Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("R2");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.Test1", b =>
                {
                    b.Property<int>("Test1Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Test1Id");

                    b.ToTable("Test1");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.Test2", b =>
                {
                    b.Property<int>("Test2Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Test1Id")
                        .HasColumnType("int");

                    b.HasKey("Test2Id");

                    b.HasIndex("Test1Id");

                    b.ToTable("Test2");
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("默认值");

                    b.Property<DateTime?>("Field14")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Field15")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)")
                        .HasComputedColumnSql("[Field12] + ', ' + [Field13]");

                    b.Property<string>("Field16")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field17")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field18")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field19")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Field2_1");

                    b.Property<string>("Field20")
                        .HasColumnType("nvarchar(max)");

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

                    b.HasKey("Id")
                        .HasName("PK_TestA");

                    b.ToTable("TestA");

                    b
                        .HasComment("测试表A");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.TestB", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field5")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestB");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.TestC", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field2")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Field3")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TestC");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.TestD", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TestD");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.TestE", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Field")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("InsertTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TestE");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.Test2", b =>
                {
                    b.HasOne("Ywt.Study.EFCore.Test1", "Test1")
                        .WithMany("Test2s")
                        .HasForeignKey("Test1Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Test1");
                });

            modelBuilder.Entity("Ywt.Study.EFCore.Test1", b =>
                {
                    b.Navigation("Test2s");
                });
#pragma warning restore 612, 618
        }
    }
}
