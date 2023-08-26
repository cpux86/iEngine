﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

#nullable disable

namespace Persistence.Migrations
{
    [DbContext(typeof(StockDbContext))]
    [Migration("20230824210236_testComplexTypedfdffgyy")]
    partial class testComplexTypedfdffgyy
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("Domain.Entities.Barcode", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Barcodes");
                });

            modelBuilder.Entity("Domain.Entities.Box", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BoxType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Comment")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Boxes");
                });

            modelBuilder.Entity("Domain.Entities.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("DocumentNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FieldsQuality")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("BoxId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("CardId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("ModifiedOn")
                        .HasColumnType("TEXT");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BoxId");

                    b.HasIndex("CardId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Domain.Entities.ProductAggregate.Card", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Card", (string)null);
                });

            modelBuilder.Entity("Domain.Entities.ProductAggregate.Cell", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Barcode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CellId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Level")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Line")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Rack")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("RackId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Zone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RackId");

                    b.ToTable("Cell");
                });

            modelBuilder.Entity("Domain.Entities.Rack", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("WarehouseId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("WarehouseId");

                    b.ToTable("Rack");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Warehouses");
                });

            modelBuilder.Entity("Domain.Entities.Product", b =>
                {
                    b.HasOne("Domain.Entities.Box", "Box")
                        .WithMany("Products")
                        .HasForeignKey("BoxId");

                    b.HasOne("Domain.Entities.ProductAggregate.Card", "Card")
                        .WithMany("Products")
                        .HasForeignKey("CardId");

                    b.Navigation("Box");

                    b.Navigation("Card");
                });

            modelBuilder.Entity("Domain.Entities.ProductAggregate.Card", b =>
                {
                    b.OwnsMany("Domain.Entities.MyClass", "MyClass", b1 =>
                        {
                            b1.Property<int>("CardId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("INTEGER");

                            b1.Property<string>("Test")
                                .IsRequired()
                                .HasColumnType("TEXT");

                            b1.HasKey("CardId", "Id");

                            b1.ToTable("MyClass");

                            b1.WithOwner()
                                .HasForeignKey("CardId");
                        });

                    b.Navigation("MyClass");
                });

            modelBuilder.Entity("Domain.Entities.ProductAggregate.Cell", b =>
                {
                    b.HasOne("Domain.Entities.Rack", null)
                        .WithMany("Cells")
                        .HasForeignKey("RackId");
                });

            modelBuilder.Entity("Domain.Entities.Rack", b =>
                {
                    b.HasOne("Domain.Entities.Warehouse", null)
                        .WithMany("Racks")
                        .HasForeignKey("WarehouseId");
                });

            modelBuilder.Entity("Domain.Entities.Box", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.ProductAggregate.Card", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("Domain.Entities.Rack", b =>
                {
                    b.Navigation("Cells");
                });

            modelBuilder.Entity("Domain.Entities.Warehouse", b =>
                {
                    b.Navigation("Racks");
                });
#pragma warning restore 612, 618
        }
    }
}
