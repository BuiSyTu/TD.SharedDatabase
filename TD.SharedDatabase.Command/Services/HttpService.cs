using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace TD.SharedDatabase.Command.Services
{
    public class HttpService
    {
        public string Address { get; set; }
        public string BearToken { get; set; }
        public List<Parameter> Headers { get; set; }
        public List<Parameter> QueryStrings { get; set; }
        
        public string Get()
        {
            var address = GetAddress();

            using HttpClient client = new HttpClient();
            var req = new HttpRequestMessage(HttpMethod.Get, address) { };

            foreach (var header in this.Headers)
            {
                req.Headers.Add(header.Key, header.Value);
            }

            if (!string.IsNullOrEmpty(this.BearToken))
            {
                req.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.BearToken);
            }

            var res = client.SendAsync(req);

            var result = string.Empty;
            if (res.Result.IsSuccessStatusCode)
            {
                result = res.Result.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        public string Post(object body)
        {
            var address = GetAddress();

            string dataString = JsonConvert.SerializeObject(body);
            StringContent data = new StringContent(dataString, Encoding.UTF8, "application/json");
            using HttpClient client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Post, address) { Content = data };

            foreach (var header in this.Headers)
            {
                request.Headers.Add(header.Key, header.Value);
            }

            if (!string.IsNullOrEmpty(this.BearToken))
            {
                request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", this.BearToken);
            }

            var response = client.SendAsync(request);

            string result = string.Empty;

            if (response.Result.IsSuccessStatusCode)
            {
                result = response.Result.Content.ReadAsStringAsync().Result;
            }

            return result;
        }

        private string GetAddress()
        {
            var result = this.Address;

            if (QueryStrings.Any())
            {
                result += "?";
                foreach (var item in this.QueryStrings)
                {
                    result += $"{item.Key}={item.Value}&";
                }

                result = this.Address.Remove(this.Address.Length - 1);
            }

            return result;
        }
    }

    public class Parameter
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
