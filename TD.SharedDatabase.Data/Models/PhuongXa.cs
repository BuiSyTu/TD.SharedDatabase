using System;

namespace TD.SharedDatabase.Data.Models
{
    public class PhuongXa
    {
        public int id { get; set; }
        public string maPhuongXa { get; set; }
        public string tenPhuongXa { get; set; }
        public string maQuanHuyen { get; set; }
        public int trangThai { get; set; } // ?
        public DateTime? ngayCapNhat { get; set; }
    }
}
