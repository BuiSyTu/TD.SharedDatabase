using System;

namespace TD.SharedDatabase.Data.Models
{
    public class GiaoVien
    {
        public int id { get; set; }
        public string ma { get; set; }
        public string ten { get; set; }
        public DateTime? ngaySinh { get; set; }
        public int gioiTinh { get; set; } //?
        public string tenGioiTinh { get; set; }
        public string soCMND { get; set; }
        public string capHoc { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string maTruong { get; set; }
        public string tenTruong { get; set; }
        public string toBoMon { get; set; }
        public string loaiCongViec { get; set; }
        public string danToc { get; set; }
        public string tenDanToc { get; set; }
        public string tonGiao { get; set; }
        public string tenTonGiao { get; set; }
        public string maTinhThanh { get; set; }
        public string tenTinhThanh { get; set; }
        public string maQuanHuyen { get; set; }
        public string tenQuanHuyen { get; set; }
        public DateTime? ngayCapCMT { get; set; }
        public string noiCapCMT { get; set; }
        public string queQuan { get; set; }
        public string diaChiThuongTru { get; set; }
        public string trinhDoNgoaiNgu { get; set; }
        public string trinhDoVanHoa { get; set; }
        public string trinhDoDaoTaoCnChinh { get; set; }
        public DateTime? ngayVaoNghe { get; set; }
        public string loaiHopDong { get; set; }
        public string bacLuong { get; set; }
        public string ngachLuong { get; set; }
        public int trangThai { get; set; } // ?
        public string tenTrinhDoNgoaiNgu { get; set; }
        public string tenTrinhDoDaoTaoCnChinh { get; set; }
        public string tenLoaiHopDong { get; set; }
        public string tenBacLuong { get; set; }
        public string tenNgachLuong { get; set; }
        public int namHoc { get; set; }
    }
}
