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
    public class GiaoVienService
    {
        private IConfiguration _configuration;
        private GiaoDucContext _giaoDucContext;
        private HttpService _httpService;

        public GiaoVienService(IConfiguration configuration, GiaoDucContext giaoDucContext, HttpService httpService)
        {
            _configuration = configuration;
            _giaoDucContext = giaoDucContext;
            _httpService = httpService;
        }

        public List<GiaoVien> Get(string maTruongHoc, int namHoc)
        {
            _httpService.Address = "http://api-tichhop.csdl.edu.vn/syncdata-api/Public/GiaoVien/GetGiaoVien";
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
                var resultStr = _httpService.Post(new { maTruongHoc = maTruongHoc, namHoc = namHoc, limit = 1000, offset = 0});
                var result = JsonConvert.DeserializeObject<DanhSachGiaoVien>(resultStr);

                return result.danhSachGiaoVien is null ? new List<GiaoVien>() : result.danhSachGiaoVien;
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
                    var giaoVien2019s = Get(maTruongHoc, 2019).Select(i => { i.namHoc = 2019; return i; });
                    var giaoVien2020s = Get(maTruongHoc, 2020).Select(i => { i.namHoc = 2020; return i; });

                    _giaoDucContext.GiaoViens.AddRange(giaoVien2019s);
                    _giaoDucContext.GiaoViens.AddRange(giaoVien2020s);
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
