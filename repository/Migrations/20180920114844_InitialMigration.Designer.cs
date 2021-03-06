﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using repository;

namespace repository.Migrations
{
    [DbContext(typeof(VersionContext))]
    [Migration("20180920114844_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("repository.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ProductName");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("repository.Version", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Changes");

                    b.Property<int?>("ContainProductId");

                    b.Property<string>("DownloadableFileName");

                    b.Property<string>("DownloadableFileUrl");

                    b.Property<string>("LongDescription");

                    b.Property<string>("ProductVersion");

                    b.Property<string>("ShortDescription");

                    b.HasKey("Id");

                    b.HasIndex("ContainProductId");

                    b.ToTable("Versions");
                });

            modelBuilder.Entity("repository.Version", b =>
                {
                    b.HasOne("repository.Product", "ContainProduct")
                        .WithMany("AllVersions")
                        .HasForeignKey("ContainProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
