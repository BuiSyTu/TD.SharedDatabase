using System;

namespace TD.SharedDatabase.Data.Models
{
    public class QuanHuyen
    {
        public int id { get; set; }
        public string maQuanHuyen { get; set; }
        public string tenQuanHuyen { get; set; }
        public string maTinhThanh { get; set; }
        public int trangThai { get; set; }
        public DateTime? ngayCapNhat { get; set; }
    }
}
