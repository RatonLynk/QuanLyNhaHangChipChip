﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL.Context;

namespace _1_DAL.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("_1_DAL.Models.BanAn", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Busy")
                        .HasMaxLength(10)
                        .HasColumnType("nchar(10)")
                        .IsFixedLength(true);

                    b.Property<int?>("Floor")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Floor");

                    b.ToTable("BanAn");
                });

            modelBuilder.Entity("_1_DAL.Models.DanhMucFood", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DanhMucFood");
                });

            modelBuilder.Entity("_1_DAL.Models.DonVi", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("DonVi");
                });

            modelBuilder.Entity("_1_DAL.Models.Floor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("int");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Floor");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<DateTime>("DateCheckIn")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateCheckOut")
                        .HasColumnType("date");

                    b.Property<int>("IdnhanVien")
                        .HasColumnType("int")
                        .HasColumnName("IDNhanVien");

                    b.Property<int>("Idtable")
                        .HasColumnType("int")
                        .HasColumnName("IDtable");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("TotalMoney")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.HasIndex("IdnhanVien");

                    b.HasIndex("Idtable");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("Idbill")
                        .HasColumnType("int")
                        .HasColumnName("IDBill");

                    b.Property<int>("Idfood")
                        .HasColumnType("int")
                        .HasColumnName("IDFood");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("Idbill");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("_1_DAL.Models.MonAnChiTiet", b =>
                {
                    b.Property<int>("MaMon")
                        .HasColumnType("int");

                    b.Property<string>("Anh")
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<int>("Idcategory")
                        .HasColumnType("int")
                        .HasColumnName("IDCategory");

                    b.Property<int>("Idmethod")
                        .HasColumnType("int")
                        .HasColumnName("IDMethod");

                    b.Property<int>("Idunit")
                        .HasColumnType("int")
                        .HasColumnName("IDUnit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<int?>("Status")
                        .HasColumnType("int");

                    b.HasKey("MaMon");

                    b.HasIndex("Idcategory");

                    b.HasIndex("Idunit");

                    b.ToTable("MonAnChiTiet");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.Property<int>("MaNv")
                        .HasColumnType("int")
                        .HasColumnName("MaNV");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<float>("Name")
                        .HasColumnType("real");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false)
                        .HasColumnType("varchar(500)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("MaNv");

                    b.HasIndex("Role");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVienNh", b =>
                {
                    b.Property<int>("MaNv")
                        .HasColumnType("int")
                        .HasColumnName("MaNV");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasMaxLength(12)
                        .IsUnicode(false)
                        .HasColumnType("varchar(12)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<bool>("Sex")
                        .HasColumnType("bit");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("MaNv");

                    b.HasIndex("Role");

                    b.ToTable("NhanVienNH");
                });

            modelBuilder.Entity("_1_DAL.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("_1_DAL.Models.ThucDon", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("money");

                    b.Property<bool?>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("ThucDon");
                });

            modelBuilder.Entity("_1_DAL.Models.BanAn", b =>
                {
                    b.HasOne("_1_DAL.Models.Floor", "FloorNavigation")
                        .WithMany("BanAns")
                        .HasForeignKey("Floor")
                        .HasConstraintName("FK_BanAn_Floor");

                    b.Navigation("FloorNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.HasOne("_1_DAL.Models.NhanVien", "IdnhanVienNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdnhanVien")
                        .HasConstraintName("FK_HoaDon_NhanVien")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.NhanVienNh", "IdnhanVien1")
                        .WithMany("HoaDons")
                        .HasForeignKey("IdnhanVien")
                        .HasConstraintName("FK_HoaDon_NhanVienNH")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.BanAn", "IdtableNavigation")
                        .WithMany("HoaDons")
                        .HasForeignKey("Idtable")
                        .HasConstraintName("FK_HoaDon_BanAn")
                        .IsRequired();

                    b.Navigation("IdnhanVien1");

                    b.Navigation("IdnhanVienNavigation");

                    b.Navigation("IdtableNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1_DAL.Models.HoaDon", "IdbillNavigation")
                        .WithMany("HoaDonChiTiets")
                        .HasForeignKey("Idbill")
                        .HasConstraintName("FK_HoaDonChiTiet_HoaDon")
                        .IsRequired();

                    b.Navigation("IdbillNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.MonAnChiTiet", b =>
                {
                    b.HasOne("_1_DAL.Models.DanhMucFood", "IdcategoryNavigation")
                        .WithMany("MonAnChiTiets")
                        .HasForeignKey("Idcategory")
                        .HasConstraintName("FK_MonAnChiTiet_DanhMucFood")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.DonVi", "IdunitNavigation")
                        .WithMany("MonAnChiTiets")
                        .HasForeignKey("Idunit")
                        .HasConstraintName("FK_MonAnChiTiet_DonVi")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.HoaDonChiTiet", "Idunit1")
                        .WithMany("MonAnChiTiets")
                        .HasForeignKey("Idunit")
                        .HasConstraintName("FK_MonAnChiTiet_HoaDonChiTiet")
                        .IsRequired();

                    b.HasOne("_1_DAL.Models.ThucDon", "MaMonNavigation")
                        .WithOne("MonAnChiTiet")
                        .HasForeignKey("_1_DAL.Models.MonAnChiTiet", "MaMon")
                        .HasConstraintName("FK_MonAnChiTiet_ThucDon")
                        .IsRequired();

                    b.Navigation("IdcategoryNavigation");

                    b.Navigation("Idunit1");

                    b.Navigation("IdunitNavigation");

                    b.Navigation("MaMonNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.HasOne("_1_DAL.Models.Role", "RoleNavigation")
                        .WithMany("NhanViens")
                        .HasForeignKey("Role")
                        .HasConstraintName("FK_NhanVien_Roles")
                        .IsRequired();

                    b.Navigation("RoleNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVienNh", b =>
                {
                    b.HasOne("_1_DAL.Models.Role", "RoleNavigation")
                        .WithMany("NhanVienNhs")
                        .HasForeignKey("Role")
                        .HasConstraintName("FK_NhanVienNH_Roles")
                        .IsRequired();

                    b.Navigation("RoleNavigation");
                });

            modelBuilder.Entity("_1_DAL.Models.BanAn", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Models.DanhMucFood", b =>
                {
                    b.Navigation("MonAnChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.DonVi", b =>
                {
                    b.Navigation("MonAnChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.Floor", b =>
                {
                    b.Navigation("BanAns");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDon", b =>
                {
                    b.Navigation("HoaDonChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.HoaDonChiTiet", b =>
                {
                    b.Navigation("MonAnChiTiets");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVien", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Models.NhanVienNh", b =>
                {
                    b.Navigation("HoaDons");
                });

            modelBuilder.Entity("_1_DAL.Models.Role", b =>
                {
                    b.Navigation("NhanVienNhs");

                    b.Navigation("NhanViens");
                });

            modelBuilder.Entity("_1_DAL.Models.ThucDon", b =>
                {
                    b.Navigation("MonAnChiTiet");
                });
#pragma warning restore 612, 618
        }
    }
}
