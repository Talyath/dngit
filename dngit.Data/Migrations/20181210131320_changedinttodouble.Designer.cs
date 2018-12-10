﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dngit.Data;

namespace dngit.Data.Migrations
{
    [DbContext(typeof(DngitContext))]
    [Migration("20181210131320_changedinttodouble")]
    partial class changedinttodouble
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("dngit.Core.Models.Place", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("Founded");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<string>("Owner");

                    b.HasKey("Id");

                    b.ToTable("Places");
                });

            modelBuilder.Entity("dngit.Core.Models.Rating", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("OverAllRating");

                    b.Property<int>("PlaceId");

                    b.HasKey("Id");

                    b.HasIndex("PlaceId")
                        .IsUnique();

                    b.ToTable("Ratings");
                });

            modelBuilder.Entity("dngit.Core.Models.RatingValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("RatingId");

                    b.Property<int>("Type");

                    b.Property<double>("Value");

                    b.HasKey("Id");

                    b.HasIndex("RatingId");

                    b.ToTable("RatingValues");
                });

            modelBuilder.Entity("dngit.Core.Models.Rating", b =>
                {
                    b.HasOne("dngit.Core.Models.Place")
                        .WithOne("Rating")
                        .HasForeignKey("dngit.Core.Models.Rating", "PlaceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("dngit.Core.Models.RatingValue", b =>
                {
                    b.HasOne("dngit.Core.Models.Rating", "Rating")
                        .WithMany("Ratings")
                        .HasForeignKey("RatingId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}