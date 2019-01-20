using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Reptile.Core
{
    public sealed class Http : IHttp
    {
        private HttpClient http;
        private HttpClientHandler handler;

        public void Close()
        {
            http.Dispose();
        }

        public bool Open()
        {
            handler = new HttpClientHandler
            {
                UseCookies = true,
                AllowAutoRedirect = true,
                AutomaticDecompression = DecompressionMethods.GZip,
                CookieContainer = new CookieContainer()
            };
            http = new HttpClient(handler);
            http.DefaultRequestHeaders.Add("Accept", "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8");
            http.DefaultRequestHeaders.Add("Accept-Language", "zh-CN,zh;q=0.9");
            http.DefaultRequestHeaders.Add("Accept-Encoding", "gzip, deflate, br");
            http.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36");
            http.DefaultRequestHeaders.Add("Connection", "keep-alive");
            http.DefaultRequestHeaders.Add("Accept-Charset", "utf8");
            return http != null;
        }

        public async Task<string> GetAsync(string url)
        {
            var response = await http.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
    }
}
