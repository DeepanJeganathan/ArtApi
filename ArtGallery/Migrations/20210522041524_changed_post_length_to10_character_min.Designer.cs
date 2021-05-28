﻿// <auto-generated />
using System;
using ArtGallery.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArtGallery.Migrations
{
    [DbContext(typeof(ArtGalleryDbContext))]
    [Migration("20210522041524_changed_post_length_to10_character_min")]
    partial class changed_post_length_to10_character_min
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArtGallery.Models.ArtModel", b =>
                {
                    b.Property<double>("ArtModelId")
                        .HasColumnType("float");

                    b.Property<string>("ArtForm")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommissionedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalLinkText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("FID")
                        .HasColumnType("float");

                    b.Property<double>("FID2")
                        .HasColumnType("float");

                    b.Property<string>("ImageAltText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageOrientation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LAT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("LONG")
                        .HasColumnType("float");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medium")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PublicArtConsultant")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Source")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThumbURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("WARD")
                        .HasColumnType("float");

                    b.Property<string>("WARD_FULLNAME")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("YEAR_INSTALLED")
                        .HasColumnType("float");

                    b.Property<string>("geometry")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArtModelId");

                    b.ToTable("ArtModels");
                });

            modelBuilder.Entity("ArtGallery.Models.Comment", b =>
                {
                    b.Property<int>("CommentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("ArtModelId")
                        .HasColumnType("float");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Post")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CommentId");

                    b.HasIndex("ArtModelId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ArtGallery.Models.Comment", b =>
                {
                    b.HasOne("ArtGallery.Models.ArtModel", "ArtModel")
                        .WithMany("comments")
                        .HasForeignKey("ArtModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ArtModel");
                });

            modelBuilder.Entity("ArtGallery.Models.ArtModel", b =>
                {
                    b.Navigation("comments");
                });
#pragma warning restore 612, 618
        }
    }
}
