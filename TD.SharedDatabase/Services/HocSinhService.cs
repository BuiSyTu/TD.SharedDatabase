using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TD.SharedDatabase.Data.Models;
using TD.SharedDatabase.ViewModels;

namespace TD.SharedDatabase.Services
{
    public class HocSinhService
    {
        private IConfiguration _configuration;
        private GiaoDucContext _giaoDucContext;
        private HttpService _httpService;

        public HocSinhService(IConfiguration configuration, GiaoDucContext giaoDucContext, HttpService httpService)
        {
            _configuration = configuration;
            _giaoDucContext = giaoDucContext;
            _httpService = httpService;
        }

        public List<HocSinh> Get(string maTruongHoc, int namHoc)
        {
            _httpService.Address = "http://api-tichhop.csdl.edu.vn/syncdata-api/Public/HocSinh/GetHocSinh";
            _httpService.BearToken = string.Empty;
            _httpService.Headers = new List<Parameter>
                {
                    new Parameter
                    {
                        Key = "Accept",
                        Value = "application/json"
                    },
                    new Parameter
                    {
                        Key = "Username",
                        Value = _configuration.GetSection("username1").Value
                    },
                    new Parameter
                    {
                        Key = "Password",
                        Value = _configuration.GetSection("password1").Value
                    }
                };
            _httpService.QueryStrings = new List<Parameter>();

            try
            {
                var resultStr = _httpService.Post(new { maTruongHoc = maTruongHoc, namHoc = namHoc, limit = 1000, offset = 0 });
                var result = JsonConvert.DeserializeObject<DanhSachHocSinh>(resultStr);

                return result.listDanhSachHocSinh is null ? new List<HocSinh>() : result.listDanhSachHocSinh;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public int Post()
        {
            try
            {
                var maTruongHocs = _giaoDucContext.TruongHocs.Select(x => x.maTruongHoc).ToList();

                foreach (var maTruongHoc in maTruongHocs)
                {
                    var hocSinh2019s = Get(maTruongHoc, 2019).Select(i => { i.namHoc = 2019; return i; });
                    var hocSinh2020s = Get(maTruongHoc, 2020).Select(i => { i.namHoc = 2020; return i; });

                    _giaoDucContext.HocSinhs.AddRange(hocSinh2019s);
                    _giaoDucContext.HocSinhs.AddRange(hocSinh2020s);
                    _giaoDucContext.SaveChanges();
                }


                return 1;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }

}
