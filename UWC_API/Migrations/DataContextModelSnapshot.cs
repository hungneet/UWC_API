﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using UWC_API.Data;

#nullable disable

namespace UWCAPI.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("UWC_API.Collector", b =>
                {
                    b.Property<int>("eId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("eId"));

                    b.Property<string>("job")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("rAddress")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("rId")
                        .HasColumnType("integer");

                    b.Property<string>("rName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("vId")
                        .HasColumnType("integer");

                    b.Property<string>("vName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("eId");

                    b.ToTable("Collector");
                });
#pragma warning restore 612, 618
        }
    }
}
