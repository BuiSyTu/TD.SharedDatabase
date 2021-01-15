using System;

namespace TD.SharedDatabase.Data.Models
{
    public class DonVi
    {
        public int id { get; set; }
        public string maDonVi { get; set; }
        public string tenDonVi { get; set; }
        public string maDonViCha { get; set; }
        public int trangThai { get; set; } // ?
        public DateTime? ngayCapNhat { get; set; }
        public string maPhuongXa { get; set; }
        public string maQuanHuyen { get; set; }
        public string maTinhThanh { get; set; }
        public int loaiDonVi { get; set; } // ?
        public string donViQuanLy { get; set; }
        public string address { get; set; }
    }
}
