using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TD.SharedDatabase.Api.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DonVi",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maDonVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenDonVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maDonViCha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    maPhuongXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maQuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maTinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loaiDonVi = table.Column<int>(type: "int", nullable: false),
                    donViQuanLy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonVi", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "GiaoVien",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    tenGioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    soCMND = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    toBoMon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loaiCongViec = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    danToc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenDanToc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tonGiao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenTonGiao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maTinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenTinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maQuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenQuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngayCapCMT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    noiCapCMT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    queQuan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diaChiThuongTru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trinhDoNgoaiNgu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trinhDoVanHoa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trinhDoDaoTaoCnChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngayVaoNghe = table.Column<DateTime>(type: "datetime2", nullable: true),
                    loaiHopDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    bacLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngachLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: false),
                    tenTrinhDoNgoaiNgu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenTrinhDoDaoTaoCnChinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenLoaiHopDong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenBacLuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenNgachLuong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GiaoVien", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "HocSinh",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isDiHocDungDoTuoi = table.Column<int>(type: "int", nullable: false),
                    ma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngaySinh = table.Column<DateTime>(type: "datetime2", nullable: true),
                    gioiTinh = table.Column<int>(type: "int", nullable: false),
                    danToc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    noiSinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diaChiThuongTru = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lopHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: false),
                    tenLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    khoiLop = table.Column<int>(type: "int", nullable: false),
                    sdtBo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sdtMe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ssoCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngayVaoTruong = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isDuXetTotNghiep = table.Column<int>(type: "int", nullable: false),
                    isTotNghiep = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinh", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "LopHoc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenLopHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    khoiHoc = table.Column<int>(type: "int", nullable: false),
                    maGvcn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phanBan = table.Column<int>(type: "int", nullable: false),
                    lopGhep = table.Column<int>(type: "int", nullable: false),
                    lopChuyen = table.Column<int>(type: "int", nullable: false),
                    buoiHoc = table.Column<int>(type: "int", nullable: false),
                    maNn1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lopVnen = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LopHoc", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "PhuongXa",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maPhuongXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenPhuongXa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maQuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhuongXa", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "QuanHuyen",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maQuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenQuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maTinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanHuyen", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TinhThanh",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maTinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenTinhThanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TinhThanh", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "TruongHoc",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    maTruongHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tenTruongHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    capHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    trangThai = table.Column<int>(type: "int", nullable: false),
                    ngayCapNhat = table.Column<DateTime>(type: "datetime2", nullable: true),
                    loaiHinhDaoTao = table.Column<int>(type: "int", nullable: false),
                    tenLoaiHinhDaoTao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    chuanQuocGia = table.Column<int>(type: "int", nullable: false),
                    loaiChuanQuocGia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maTthon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maPxa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maQhuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maTthanh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    loaiHinhTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    vungKhoKhan = table.Column<int>(type: "int", nullable: false),
                    vungBienGioi = table.Column<int>(type: "int", nullable: false),
                    chiBoDang = table.Column<int>(type: "int", nullable: false),
                    website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sdt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    fax = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maDonVi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ngayThanhLap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    tenHieuTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sdtHieuTruong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    diaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maNhomCapHoc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maSo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    maPhong = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruongHoc", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DonVi");

            migrationBuilder.DropTable(
                name: "GiaoVien");

            migrationBuilder.DropTable(
                name: "HocSinh");

            migrationBuilder.DropTable(
                name: "LopHoc");

            migrationBuilder.DropTable(
                name: "PhuongXa");

            migrationBuilder.DropTable(
                name: "QuanHuyen");

            migrationBuilder.DropTable(
                name: "TinhThanh");

            migrationBuilder.DropTable(
                name: "TruongHoc");
        }
    }
}
