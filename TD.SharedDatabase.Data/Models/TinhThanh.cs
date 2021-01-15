using System;

namespace TD.SharedDatabase.Data.Models
{
    public class TinhThanh
    {
        public int id { get; set; }
        public string maTinhThanh { get; set; }
        public string tenTinhThanh { get; set; }
        public int trangThai { get; set; } // ?
        public DateTime? ngayCapNhat { get; set; }
    }
}
