using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Services
{
    public class TinhThanhService
    {
        private IConfiguration _configuration;
        private GiaoDucContext _giaoDucContext;
        private HttpService _httpService;

        public TinhThanhService(IConfiguration configuration, GiaoDucContext giaoDucContext, HttpService httpService)
        {
            _configuration = configuration;
            _giaoDucContext = giaoDucContext;
            _httpService = httpService;
        }

        public List<TinhThanh> Get()
        {
            _httpService.Address = "http://api-tichhop.csdl.edu.vn/syncdata-api/Public/DanhMuc/GetTinhThanh";
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
                        Value = _configuration.GetSection("Username").Value
                    },
                    new Parameter
                    {
                        Key = "Password",
                        Value = _configuration.GetSection("Password").Value
                    }
                };
            _httpService.QueryStrings = new List<Parameter>();

            try
            {
                var resultStr = _httpService.Post(new { maTinhThanh = "36" });
                var result = JsonConvert.DeserializeObject<List<TinhThanh>>(resultStr);

                return result;
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
                var tinhThanhs = Get();
                _giaoDucContext.TinhThanhs.AddRange(tinhThanhs);
                _giaoDucContext.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
