﻿// <auto-generated />
using System;
using BonsaiServer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BonsaiServer.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190217113759_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BonsaiServer.Database.Mutation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("End");

                    b.Property<int?>("Plant1Id");

                    b.Property<int?>("Plant2Id");

                    b.Property<DateTime>("Start");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("Plant1Id");

                    b.HasIndex("Plant2Id");

                    b.HasIndex("UserId");

                    b.ToTable("Mutations");
                });

            modelBuilder.Entity("BonsaiServer.Database.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DirtColor")
                        .HasMaxLength(3);

                    b.Property<string>("FlowerColor")
                        .HasMaxLength(3);

                    b.Property<byte>("FlowersId");

                    b.Property<string>("LeavesColor")
                        .HasMaxLength(3);

                    b.Property<byte>("LeavesId");

                    b.Property<string>("Name")
                        .HasMaxLength(20);

                    b.Property<string>("PotColor")
                        .HasMaxLength(3);

                    b.Property<byte>("Rarity");

                    b.Property<byte>("Slot");

                    b.Property<string>("SoilColor")
                        .HasMaxLength(3);

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Plants");
                });

            modelBuilder.Entity("BonsaiServer.Database.Session", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("SessionHash")
                        .HasMaxLength(64);

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Sessions");
                });

            modelBuilder.Entity("BonsaiServer.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasMaxLength(32);

                    b.Property<string>("Login")
                        .HasMaxLength(16);

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(64);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("BonsaiServer.Database.Mutation", b =>
                {
                    b.HasOne("BonsaiServer.Database.Plant", "Plant1")
                        .WithMany()
                        .HasForeignKey("Plant1Id");

                    b.HasOne("BonsaiServer.Database.Plant", "Plant2")
                        .WithMany()
                        .HasForeignKey("Plant2Id");

                    b.HasOne("BonsaiServer.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BonsaiServer.Database.Plant", b =>
                {
                    b.HasOne("BonsaiServer.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("BonsaiServer.Database.Session", b =>
                {
                    b.HasOne("BonsaiServer.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}