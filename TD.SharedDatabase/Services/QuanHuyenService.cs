using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Services
{
    public class QuanHuyenService
    {
        private IConfiguration _configuration;
        private GiaoDucContext _giaoDucContext;
        private HttpService _httpService;

        public QuanHuyenService(IConfiguration configuration, GiaoDucContext giaoDucContext, HttpService httpService)
        {
            _configuration = configuration;
            _giaoDucContext = giaoDucContext;
            _httpService = httpService;
        }

        public List<QuanHuyen> Get()
        {
            _httpService.Address = "http://api-tichhop.csdl.edu.vn/syncdata-api/Public/DanhMuc/GetQuanHuyen";
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
                var resultStr = _httpService.Post(new { maTinhThanh = "36" });
                var result = JsonConvert.DeserializeObject<List<QuanHuyen>>(resultStr);

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
                var quanHuyens = Get();
                _giaoDucContext.QuanHuyens.AddRange(quanHuyens);
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
