using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TD.SharedDatabase.Data.Models;

namespace TD.SharedDatabase.Command.Services
{
    public class TinhThanhService
    {
        public List<TinhThanh> Get()
        {
            var httpService = new HttpService
            {
                Address = "http://api-tichhop.csdl.edu.vn/syncdata-api/Public/DanhMuc/GetTinhThanh",
                BearToken = string.Empty,
                Headers = new List<Parameter>
                {
                    new Parameter
                    {
                        Key = "Accept",
                        Value = "application/json"
                    },
                    new Parameter
                    {
                        Key = "Username",
                        Value = "vlg_sync"
                    },
                    new Parameter
                    {
                        Key = "Password",
                        Value = "vlg@2020#"
                    }
                },
                QueryStrings = new List<Parameter>()
            };

            try
            {
                var resultStr = httpService.Post(new { maTinhThanh = "86" });
                var result = JsonConvert.DeserializeObject<List<TinhThanh>>(resultStr);

                return result;
            } 
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Post()
        {
        }
    }
}
