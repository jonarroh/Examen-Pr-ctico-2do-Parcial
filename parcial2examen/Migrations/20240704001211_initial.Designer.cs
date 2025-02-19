﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using parcial2examen.Modelos;

#nullable disable

namespace parcial2examen.Migrations
{
    [DbContext(typeof(ProductoContext))]
    [Migration("20240704001211_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("parcial2examen.Modelos.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("Categoria")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 52,
                            Categoria = "Usa",
                            Image = "https://m.media-amazon.com/images/I/81moh0ogZCL._UF1000,1000_QL80_.jpg",
                            Nombre = "Clancy",
                            Precio = 685m
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 52,
                            Categoria = "MXN",
                            Image = "https://shop.republicrecords.com/cdn/shop/files/SPOTIFY-THEWARNING_LP_MOCKUP_58_88_1.png?v=1711996978",
                            Nombre = "Keep Me Feed",
                            Precio = 485m
                        },
                        new
                        {
                            Id = 3,
                            Cantidad = 52,
                            Categoria = "MXN",
                            Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQLkZTSGluevAlHw1F4BXwLzKo4skJnFxluWA&s",
                            Nombre = "Music Of The Sphere",
                            Precio = 485m
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
