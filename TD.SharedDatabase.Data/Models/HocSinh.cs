using System;

namespace TD.SharedDatabase.Data.Models
{
    public class HocSinh
    {
        public int id { get; set; }
        public string maTruong { get; set; }
        public string tenTruong { get; set; }
        public int isDiHocDungDoTuoi { get; set; } // ?
        public string ma { get; set; }
        public string ten { get; set; }
        public DateTime? ngaySinh { get; set; }
        public int gioiTinh { get; set; } // ?
        public string danToc { get; set; }
        public string noiSinh { get; set; }
        public string diaChiThuongTru { get; set; }
        public string lopHoc {get;set;}
        public int trangThai { get; set; } // ?
        public string tenLopHoc { get; set; }
        public int khoiLop { get; set; } // ?
        public string sdtBo { get; set; }
        public string sdtMe { get; set; }
        public string ssoCode { get; set; }
        public DateTime? ngayVaoTruong { get; set; }
        public int isDuXetTotNghiep { get; set; } // ?
        public int isTotNghiep { get; set; } // ?
        public int namHoc { get; set; }
    }
}
