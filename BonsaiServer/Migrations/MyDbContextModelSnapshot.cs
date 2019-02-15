﻿// <auto-generated />
using BonsaiServer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace BonsaiServer.Migrations
{
    [DbContext(typeof(BonsaiDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BonsaiServer.Model.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

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

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });
#pragma warning restore 612, 618
        }
    }
}
