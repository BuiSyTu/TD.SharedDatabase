using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.ViewModels
{
    public class DanhSachGiaoVien
    {
        public List<GiaoVien> danhSachGiaoVien { get; set; }
        public string returnCode { get; set; }
    }
}
