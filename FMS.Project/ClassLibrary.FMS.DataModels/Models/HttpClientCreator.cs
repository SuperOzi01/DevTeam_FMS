using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.FMS.DataModels.Models
{
    public static class HttpClientCreator
    {
        public static HttpClient CreateHttpClient(string BaseURL , string Header)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(BaseURL);
            string token = Header;
            if (token != null)
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(token);
            return client;
        }
    }
}
