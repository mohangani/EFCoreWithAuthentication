﻿// <auto-generated />
using System;
using EFCoreApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreApi.Migrations
{
    [DbContext(typeof(ShopperStopDbContext))]
    [Migration("20221118110535_sync1")]
    partial class sync1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("State")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Street")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BookDetails_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BookDetails_Id")
                        .IsUnique();

                    b.ToTable("Books");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.BookDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BookDetails");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Gender", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "5"
                        });
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PrdTypeId")
                        .HasColumnType("int");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrdTypeId");

                    b.HasIndex("SellerId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "1"
                        },
                        new
                        {
                            Id = 2,
                            Name = "2"
                        },
                        new
                        {
                            Id = 3,
                            Name = "3"
                        },
                        new
                        {
                            Id = 4,
                            Name = "4"
                        },
                        new
                        {
                            Id = 5,
                            Name = "5"
                        },
                        new
                        {
                            Id = 6,
                            Name = "6"
                        },
                        new
                        {
                            Id = 7,
                            Name = "7"
                        },
                        new
                        {
                            Id = 8,
                            Name = "8"
                        },
                        new
                        {
                            Id = 9,
                            Name = "9"
                        },
                        new
                        {
                            Id = 10,
                            Name = "10"
                        },
                        new
                        {
                            Id = 11,
                            Name = "11"
                        },
                        new
                        {
                            Id = 12,
                            Name = "12"
                        },
                        new
                        {
                            Id = 13,
                            Name = "13"
                        },
                        new
                        {
                            Id = 14,
                            Name = "14"
                        },
                        new
                        {
                            Id = 15,
                            Name = "15"
                        },
                        new
                        {
                            Id = 16,
                            Name = "16"
                        });
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("Id");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            Id = 2,
                            RoleName = "User"
                        },
                        new
                        {
                            Id = 3,
                            RoleName = "Guest"
                        });
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float?>("Height")
                        .HasColumnType("real");

                    b.Property<string>("ProductSize")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float?>("Width")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Dob")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("RoleId")
                        .IsUnique();

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.HasIndex("FirstName", "LastName", "Dob")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Book", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.BookDetail", "BookDetails")
                        .WithOne("Book")
                        .HasForeignKey("EFCoreApi.Models.DbModels.Book", "BookDetails_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BookDetails");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Cart", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.Product", "Product")
                        .WithOne("Cart")
                        .HasForeignKey("EFCoreApi.Models.DbModels.Cart", "ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreApi.Models.DbModels.User", "User")
                        .WithOne("Cart")
                        .HasForeignKey("EFCoreApi.Models.DbModels.Cart", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Image", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.Product", "Product")
                        .WithMany("ImageUrl")
                        .HasForeignKey("ProductId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Product", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.ProductType", "ProductType")
                        .WithMany("Product")
                        .HasForeignKey("PrdTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreApi.Models.DbModels.Seller", "Seller")
                        .WithMany("Product")
                        .HasForeignKey("SellerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreApi.Models.DbModels.Size", "Size")
                        .WithMany("Product")
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");

                    b.Navigation("Seller");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Seller", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.Address", "Address")
                        .WithOne("Seller")
                        .HasForeignKey("EFCoreApi.Models.DbModels.Seller", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.User", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.Address", "Address")
                        .WithOne("User")
                        .HasForeignKey("EFCoreApi.Models.DbModels.User", "AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCoreApi.Models.DbModels.Role", "Role")
                        .WithOne("User")
                        .HasForeignKey("EFCoreApi.Models.DbModels.User", "RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Address", b =>
                {
                    b.Navigation("Seller");

                    b.Navigation("User");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.BookDetail", b =>
                {
                    b.Navigation("Book");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Product", b =>
                {
                    b.Navigation("Cart");

                    b.Navigation("ImageUrl");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.ProductType", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Seller", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Size", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.User", b =>
                {
                    b.Navigation("Cart");
                });
#pragma warning restore 612, 618
        }
    }
}
