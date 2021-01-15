using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Services
{
    public class PhuongXaService
    {
        private IConfiguration _configuration;
        private GiaoDucContext _giaoDucContext;
        private HttpService _httpService;

        public PhuongXaService(IConfiguration configuration, GiaoDucContext giaoDucContext, HttpService httpService)
        {
            _configuration = configuration;
            _giaoDucContext = giaoDucContext;
            _httpService = httpService;
        }

        public List<PhuongXa> Get(string maQuanHuyen)
        {
            _httpService.Address = "http://api-tichhop.csdl.edu.vn/syncdata-api/Public/DanhMuc/GetPhuongXa";
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
                var resultStr = _httpService.Post(new { maQuanHuyen = maQuanHuyen });
                var result = JsonConvert.DeserializeObject<List<PhuongXa>>(resultStr);

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
                var maQuanHuyens = _giaoDucContext.QuanHuyens.Select(x => x.maQuanHuyen).ToList();

                foreach (var maQuanHuyen in maQuanHuyens)
                {
                    var phuongXas = Get(maQuanHuyen);
                    _giaoDucContext.PhuongXas.AddRange(phuongXas);
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
