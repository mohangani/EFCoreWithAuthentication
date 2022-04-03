﻿// <auto-generated />
using System;
using EFCoreApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreApi.Migrations
{
    [DbContext(typeof(ShopperStopDbContext))]
    partial class ShopperStopDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.Property<string>("Country")
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

                    b.HasKey("AddressId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Gender", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Male"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Female"
                        },
                        new
                        {
                            Id = 3,
                            Name = "TransGenderMale"
                        },
                        new
                        {
                            Id = 4,
                            Name = "TransGenderFemale"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hizra"
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
                    b.Property<int>("ProductId")
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

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int?>("ProductTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("SellerId")
                        .HasColumnType("int");

                    b.Property<int?>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("ProductTypeId");

                    b.HasIndex("SellerId");

                    b.HasIndex("SizeId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ProductTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Computer"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = 3,
                            Name = "KeyBords"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Speakers"
                        },
                        new
                        {
                            Id = 5,
                            Name = "HeadPhones"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Chrgers"
                        },
                        new
                        {
                            Id = 7,
                            Name = "PowerCables"
                        },
                        new
                        {
                            Id = 8,
                            Name = "Tv"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Shoes"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Mobiles"
                        },
                        new
                        {
                            Id = 11,
                            Name = "chairs"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Fridge"
                        },
                        new
                        {
                            Id = 13,
                            Name = "WashingMachine"
                        },
                        new
                        {
                            Id = 14,
                            Name = "Clothes"
                        },
                        new
                        {
                            Id = 15,
                            Name = "Grinder"
                        },
                        new
                        {
                            Id = 16,
                            Name = "Mixer"
                        });
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            RoleName = "Admin"
                        },
                        new
                        {
                            RoleId = 2,
                            RoleName = "User"
                        },
                        new
                        {
                            RoleId = 3,
                            RoleName = "Guest"
                        });
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Seller", b =>
                {
                    b.Property<int>("SellerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(24)
                        .HasColumnType("nvarchar(24)");

                    b.HasKey("SellerId");

                    b.HasIndex("AddressId");

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

                    b.Property<int>("ProductSize")
                        .HasColumnType("int");

                    b.Property<float?>("Width")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Sizes");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId")
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

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

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

                    b.Property<int?>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("UserId");

                    b.HasIndex("AddressId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserName")
                        .IsUnique();

                    b.HasIndex("FirstName", "LastName", "Dob")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Image", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.Product", null)
                        .WithMany("ImageUrl")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Product", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.ProductType", "ProductType")
                        .WithMany()
                        .HasForeignKey("ProductTypeId");

                    b.HasOne("EFCoreApi.Models.DbModels.Seller", "Seller")
                        .WithMany()
                        .HasForeignKey("SellerId");

                    b.HasOne("EFCoreApi.Models.DbModels.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId");

                    b.Navigation("ProductType");

                    b.Navigation("Seller");

                    b.Navigation("Size");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Seller", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.User", b =>
                {
                    b.HasOne("EFCoreApi.Models.DbModels.Address", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.HasOne("EFCoreApi.Models.DbModels.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Address");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("EFCoreApi.Models.DbModels.Product", b =>
                {
                    b.Navigation("ImageUrl");
                });
#pragma warning restore 612, 618
        }
    }
}
