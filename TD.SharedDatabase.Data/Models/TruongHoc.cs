using System;

namespace TD.SharedDatabase.Data.Models
{
    public class TruongHoc
    {
        public int id { get; set; }
        public string maTruongHoc { get; set; }
        public string tenTruongHoc { get; set; }
        public string capHoc { get; set; }
        public int trangThai { get; set; } // ?
        public DateTime? ngayCapNhat { get; set; }
        public int loaiHinhDaoTao { get; set; } // ?
        public string tenLoaiHinhDaoTao { get; set; }
        public int chuanQuocGia { get; set; } // ?
        public string loaiChuanQuocGia { get; set; }
        public string maTthon { get; set; }
        public string maPxa { get; set; }
        public string maQhuyen { get; set; }
        public string maTthanh { get; set; }
        public int loaiHinhTruong { get; set; }
        public int vungKhoKhan { get; set; } // ?
        public int vungBienGioi { get; set; } // ?
        public int chiBoDang { get; set; }
        public string website { get; set; }
        public string sdt { get; set; }
        public string email { get; set; }
        public string fax { get; set; }
        public string maDonVi { get; set; }
        public DateTime? ngayThanhLap { get; set; }
        public string tenHieuTruong { get; set; }
        public string sdtHieuTruong { get; set; }
        public string diaChi { get; set; }
        public string maNhomCapHoc { get; set; }
        public string maSo { get; set; }
        public string maPhong { get; set; }
    }
}
