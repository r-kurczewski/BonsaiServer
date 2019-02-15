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
    [Migration("20190214174831_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BonsaiServer.Model.Plant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("DirtColor");

                    b.Property<string>("FlowerColor");

                    b.Property<int>("FlowersId");

                    b.Property<string>("LeavesColor");

                    b.Property<int>("LeavesId");

                    b.Property<string>("Name");

                    b.Property<string>("PotColor");

                    b.Property<int>("Rarity");

                    b.Property<int>("Slot");

                    b.Property<string>("SoilColor");

                    b.HasKey("Id");

                    b.ToTable("Plants");
                });
#pragma warning restore 612, 618
        }
    }
}