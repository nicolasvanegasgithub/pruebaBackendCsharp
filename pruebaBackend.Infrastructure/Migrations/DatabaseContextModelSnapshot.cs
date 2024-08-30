﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pruebaBackend.Infrastructure;

#nullable disable

namespace pruebaBackend.Infrastructure.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("pruebaBackend.Domain.Entities.Brands", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.HasKey("Id");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("pruebaBackend.Domain.Entities.Cars", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BrandId");

                    b.ToTable("Cars");
                });

            modelBuilder.Entity("pruebaBackend.Domain.Entities.Brands", b =>
                {
                    b.OwnsOne("pruebaBackend.Domain.ValueObjects.Brands.BrandName", "Name", b1 =>
                        {
                            b1.Property<int>("BrandsId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Name");

                            b1.HasKey("BrandsId");

                            b1.ToTable("Brands");

                            b1.WithOwner()
                                .HasForeignKey("BrandsId");
                        });

                    b.Navigation("Name")
                        .IsRequired();
                });

            modelBuilder.Entity("pruebaBackend.Domain.Entities.Cars", b =>
                {
                    b.HasOne("pruebaBackend.Domain.Entities.Brands", "Brand")
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("pruebaBackend.Domain.ValueObjects.Cars.CarDescription", "Description", b1 =>
                        {
                            b1.Property<int>("CarsId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Description");

                            b1.HasKey("CarsId");

                            b1.ToTable("Cars");

                            b1.WithOwner()
                                .HasForeignKey("CarsId");
                        });

                    b.OwnsOne("pruebaBackend.Domain.ValueObjects.Cars.CarKm", "Km", b1 =>
                        {
                            b1.Property<int>("CarsId")
                                .HasColumnType("int");

                            b1.Property<int>("Value")
                                .HasColumnType("int")
                                .HasColumnName("Km");

                            b1.HasKey("CarsId");

                            b1.ToTable("Cars");

                            b1.WithOwner()
                                .HasForeignKey("CarsId");
                        });

                    b.OwnsOne("pruebaBackend.Domain.ValueObjects.Cars.CarModel", "Model", b1 =>
                        {
                            b1.Property<int>("CarsId")
                                .HasColumnType("int");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)")
                                .HasColumnName("Model");

                            b1.HasKey("CarsId");

                            b1.ToTable("Cars");

                            b1.WithOwner()
                                .HasForeignKey("CarsId");
                        });

                    b.OwnsOne("pruebaBackend.Domain.ValueObjects.Cars.CarPrice", "Price", b1 =>
                        {
                            b1.Property<int>("CarsId")
                                .HasColumnType("int");

                            b1.Property<int>("Value")
                                .HasColumnType("int")
                                .HasColumnName("Price");

                            b1.HasKey("CarsId");

                            b1.ToTable("Cars");

                            b1.WithOwner()
                                .HasForeignKey("CarsId");
                        });

                    b.Navigation("Brand");

                    b.Navigation("Description");

                    b.Navigation("Km")
                        .IsRequired();

                    b.Navigation("Model")
                        .IsRequired();

                    b.Navigation("Price")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
