﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Movies.Models.Data;

namespace Movies.Migrations
{
    [DbContext(typeof(MoviesDbContext))]
    partial class MoviesDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Movies.Models.Actor", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Bithdate")
                        .HasColumnType("datetime2");

                    b.Property<long>("ClustedID")
                        .HasColumnType("bigint");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("MovieID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID")
                        .IsClustered(false);

                    b.HasIndex("ClustedID")
                        .IsClustered();

                    b.HasIndex("MovieID");

                    b.ToTable("Actors");
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("ClustedID")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Imdb")
                        .HasColumnType("float");

                    b.Property<DateTime>("ReleaseDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID")
                        .IsClustered(false);

                    b.HasIndex("ClustedID")
                        .IsClustered();

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("Movies.Models.Actor", b =>
                {
                    b.HasOne("Movies.Models.Movie", null)
                        .WithMany("Cast")
                        .HasForeignKey("MovieID");
                });

            modelBuilder.Entity("Movies.Models.Movie", b =>
                {
                    b.Navigation("Cast");
                });
#pragma warning restore 612, 618
        }
    }
}