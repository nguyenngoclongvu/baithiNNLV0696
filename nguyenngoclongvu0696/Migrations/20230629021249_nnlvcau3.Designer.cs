﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace nguyenngoclongvu0696.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230629021249_nnlvcau3")]
    partial class nnlvcau3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("nguyenngoclongvu0696.Models.nnlvcau3", b =>
                {
                    b.Property<string>("HoTen")
                        .HasColumnType("TEXT");

                    b.Property<string>("LopHoc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("HoTen");

                    b.ToTable("nnlvcau3");
                });
#pragma warning restore 612, 618
        }
    }
}