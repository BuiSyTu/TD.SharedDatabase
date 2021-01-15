using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Services
{
    public class ChiTieuService
    {
        private GiaoDucContext _giaoDucContext;
        private HttpService _httpService;

        public ChiTieuService(GiaoDucContext giaoDucContext, HttpService httpService)
        {
            _giaoDucContext = giaoDucContext;
            _httpService = httpService;
        }

        public int GetValue(string indicatorCode, int dataYear)
        {
            switch (indicatorCode)
            {
                // Số học sinh tiểu học
                case "T1501-1":
                    return _giaoDucContext.HocSinhs.Where(x => x.khoiLop >= 1 && x.khoiLop <= 5 && x.namHoc == dataYear).Count();
                // Số giáo viên tiểu học
                case "T1501-2":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "1" && x.namHoc == dataYear).Count();
                // Số học sinh trung học sơ sở
                case "T1501-3": 
                    return _giaoDucContext.HocSinhs.Where(x => x.khoiLop >= 6 && x.khoiLop <= 9 && x.namHoc == dataYear).Count();
                // Số giáo viên trung học cơ sở
                case "T1501-4": 
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "2" && x.namHoc == dataYear).Count();
                // Số học sinh trung học phổ thông
                case "T1501-5": 
                    return _giaoDucContext.HocSinhs.Where(x => x.khoiLop >= 6 && x.khoiLop <= 9 && x.namHoc == dataYear).Count();
                // Số giáo viên trung học phổ thông
                case "T1501-6": 
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "3" && x.namHoc == dataYear).Count();
                // Số lớp học tiểu học
                case "T1502-1": 
                    return _giaoDucContext.LopHocs.Where(x => x.khoiHoc >= 1 && x.khoiHoc <= 5 && x.namHoc == dataYear).Count();
                // Số lớp học trung học cơ sở
                case "T1502-2":
                    return _giaoDucContext.LopHocs.Where(x => x.khoiHoc >= 6 && x.khoiHoc <= 9 && x.namHoc == dataYear).Count();
                // Số lớp học trung học phổ thông
                case "T1502-3":
                    return _giaoDucContext.LopHocs.Where(x => x.khoiHoc >= 10 && x.khoiHoc <= 12 && x.namHoc == dataYear).Count();
                // Số trường tiểu học
                case "T1504-1":
                    return _giaoDucContext.TruongHocs.Where(x => x.capHoc == "1").Count();
                // Số lớp học tiểu học
                case "T1504-2":
                    return _giaoDucContext.LopHocs.Where(x => x.khoiHoc >=1 && x.khoiHoc <= 5 && x.namHoc == dataYear).Count();
                // Số trường trung học cơ sở
                case "T1504-4":
                    return _giaoDucContext.TruongHocs.Where(x => x.capHoc == "2").Count();
                // Số lớp trung học cơ sở
                case "T1504-5":
                    return _giaoDucContext.LopHocs.Where(x => x.khoiHoc >= 6 && x.khoiHoc <= 9 && x.namHoc == dataYear).Count();
                // Số trường trung học phổ thông
                case "T1504-7":
                    return _giaoDucContext.TruongHocs.Where(x => x.capHoc == "3").Count();
                // Số lớp trung học phổ thông
                case "T1504-8":
                    return _giaoDucContext.LopHocs.Where(x => x.khoiHoc >= 10 && x.khoiHoc <= 12 && x.namHoc == dataYear).Count();
                // Số giáo viên tiểu học
                case "T1505-1":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "1" && x.namHoc == dataYear).Count();
                // Số giáo viên tiểu học là nữ
                case "T1505-1a":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "1" && x.gioiTinh == 0 && x.namHoc == dataYear).Count();
                // Số giáo viên tiểu học là dân tộc ít người
                case "T1505-1b":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "1" && x.danToc != "1" && x.namHoc == dataYear).Count();
                // Số giáo viên trung học cơ sở
                case "T1505-2":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "2" && x.namHoc == dataYear).Count();
                // Số giáo viên trung học cơ sở là nữ
                case "T1505-2a":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "2" && x.gioiTinh == 0 && x.namHoc == dataYear).Count();
                // Số giáo viên trung học cơ sở là dân tộc ít người
                case "T1505-2b":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "2" && x.danToc != "1" && x.namHoc == dataYear).Count();
                // Số giáo viên trung học phổ thông
                case "T1505-3":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "3" && x.namHoc == dataYear).Count();
                // Số giáo viên trung học phổ thông là nữ
                case "T1505-3a":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "3" && x.gioiTinh == 0 && x.namHoc == dataYear).Count();
                // Số giáo viên trung học phổ thông là dân tộc ít người
                case "T1505-3b":
                    return _giaoDucContext.GiaoViens.Where(x => x.capHoc == "3" && x.danToc != "1" && x.namHoc == dataYear).Count();
                default:
                    return 0;
            }
        }

        public void Add()
        {
            _httpService.Address = "https://baocao.namdinh.gov.vn/_vti_bin/td.bc.dw/dwservice.svc/CapNhatChiTieuDonVi";
            _httpService.BearToken = string.Empty;
            _httpService.Headers = new List<Parameter>();
            _httpService.QueryStrings = new List<Parameter>();

            var indicatorCodes = new List<string>
            {
                "T1501-1", "T1501-2", "T1501-3", "T1501-4", "T1501-5", "T1501-6",
                "T1502-1", "T1502-2", "T1502-3",
                "T1504-1", "T1504-2", "T1504-4", "T1504-5", "T1504-7", "T1504-8",
                "T1505-1", "T1505-1a", "T1505-1b", "T1505-2", "T1505-2a", "T1505-2b", "T1505-3", "T1505-3a", "T1505-3b"
            };

            foreach (var indicatorCode in indicatorCodes)
            {
                int value2019 = GetValue(indicatorCode, 2019);
                int value2020 = GetValue(indicatorCode, 2020);

                _httpService.Post(new {
                    dataTypeId = 3,
                    dataYear = 2019,
                    indicatorCode = indicatorCode,
                    officeCode = "000-00-03-H40",
                    periodId = 20,
                    value = value2019,
                    textValue = value2019.ToString()
                });

                _httpService.Post(new
                {
                    dataTypeId = 3,
                    dataYear = 2020,
                    indicatorCode = indicatorCode,
                    officeCode = "000-00-03-H40",
                    periodId = 20,
                    value = value2020,
                    textValue = value2020.ToString()
                });
            }
        }
    }
}
