﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Api.Migrations
{
    [DbContext(typeof(GiaoDucContext))]
    [Migration("20210114050017_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.DonVi", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("donViQuanLy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("loaiDonVi")
                        .HasColumnType("int");

                    b.Property<string>("maDonVi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maDonViCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maPhuongXa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maQuanHuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTinhThanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenDonVi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("DonVi");
                });

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.GiaoVien", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("bacLuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("capHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("danToc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiThuongTru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("loaiCongViec")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loaiHopDong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maQuanHuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTinhThanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ngachLuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngayCapCMT")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngayVaoNghe")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiCapCMT")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("queQuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soCMND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenBacLuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenDanToc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenGioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenLoaiHopDong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenNgachLuong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenQuanHuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTinhThanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTonGiao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTrinhDoDaoTaoCnChinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTrinhDoNgoaiNgu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("toBoMon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tonGiao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.Property<string>("trinhDoDaoTaoCnChinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trinhDoNgoaiNgu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("trinhDoVanHoa")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("GiaoVien");
                });

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.HocSinh", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("danToc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("diaChiThuongTru")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("gioiTinh")
                        .HasColumnType("int");

                    b.Property<int>("isDiHocDungDoTuoi")
                        .HasColumnType("int");

                    b.Property<int>("isDuXetTotNghiep")
                        .HasColumnType("int");

                    b.Property<int>("isTotNghiep")
                        .HasColumnType("int");

                    b.Property<int>("khoiLop")
                        .HasColumnType("int");

                    b.Property<string>("lopHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngaySinh")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngayVaoTruong")
                        .HasColumnType("datetime2");

                    b.Property<string>("noiSinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sdtBo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sdtMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ssoCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenLopHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("HocSinh");
                });

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.LopHoc", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("buoiHoc")
                        .HasColumnType("int");

                    b.Property<int>("khoiHoc")
                        .HasColumnType("int");

                    b.Property<int>("lopChuyen")
                        .HasColumnType("int");

                    b.Property<int>("lopGhep")
                        .HasColumnType("int");

                    b.Property<int>("lopVnen")
                        .HasColumnType("int");

                    b.Property<string>("maGvcn")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maLopHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maNn1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("phanBan")
                        .HasColumnType("int");

                    b.Property<string>("tenLopHoc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.PhuongXa", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("maPhuongXa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maQuanHuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenPhuongXa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("PhuongXa");
                });

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.QuanHuyen", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("maQuanHuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTinhThanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenQuanHuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("QuanHuyen");
                });

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.TinhThanh", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("maTinhThanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<string>("tenTinhThanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("TinhThanh");
                });

            modelBuilder.Entity("TD.SharedDatabase.Data.Models.TruongHoc", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("capHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("chiBoDang")
                        .HasColumnType("int");

                    b.Property<int>("chuanQuocGia")
                        .HasColumnType("int");

                    b.Property<string>("diaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("loaiChuanQuocGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("loaiHinhDaoTao")
                        .HasColumnType("int");

                    b.Property<string>("loaiHinhTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maDonVi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maNhomCapHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maPhong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maPxa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maQhuyen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maSo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTruongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTthanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("maTthon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ngayCapNhat")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ngayThanhLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("sdt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sdtHieuTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenHieuTruong")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenLoaiHinhDaoTao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenTruongHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("trangThai")
                        .HasColumnType("int");

                    b.Property<int>("vungBienGioi")
                        .HasColumnType("int");

                    b.Property<int>("vungKhoKhan")
                        .HasColumnType("int");

                    b.Property<string>("website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("TruongHoc");
                });
#pragma warning restore 612, 618
        }
    }
}
