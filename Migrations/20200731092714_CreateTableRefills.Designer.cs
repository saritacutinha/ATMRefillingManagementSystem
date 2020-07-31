﻿// <auto-generated />
using System;
using ATMRefillingManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ATMRefillingManagementSystem.Migrations
{
    [DbContext(typeof(ATMRefillingManagementSystemDbContext))]
    [Migration("20200731092714_CreateTableRefills")]
    partial class CreateTableRefills
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ATMRefillingManagementSystem.Core.Models.Bank", b =>
                {
                    b.Property<int>("BankId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BankId");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("ATMRefillingManagementSystem.Core.Models.Refill", b =>
                {
                    b.Property<int>("RefillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Area")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BankID")
                        .HasColumnType("int");

                    b.Property<string>("KeyQualifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("RID");

                    b.Property<DateTime>("RefillDate")
                        .HasColumnType("datetime2");

                    b.HasKey("RefillID");

                    b.HasIndex("BankID");

                    b.ToTable("Refills");
                });

            modelBuilder.Entity("ATMRefillingManagementSystem.Core.Models.Refill", b =>
                {
                    b.HasOne("ATMRefillingManagementSystem.Core.Models.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}