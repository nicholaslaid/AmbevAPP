using Ambev.Global;
using Ambev.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambev.Api
{
    public class ApiBase
    {
        public Result GetComand(string url)
        {
            Result result = new Result();

            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");

            HttpResponseMessage response = client.GetAsync(Config.apiBaseUrl + url).Result;
            string responseString = response.Content.ReadAsStringAsync().Result;

            result = JsonConvert.DeserializeObject<Result>(responseString);

            return result;

        }
    }
}
