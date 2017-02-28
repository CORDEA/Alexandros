using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Alexandros
{
    public class ApiClient
    {
        private const string BaseUrl = "https://itunes.apple.com/search";

        private static HttpClient HttpClient { get; } = new HttpClient();

        private static string GetSearchUrl(string term, string lang, string country, int limit)
        {
            var param = new Dictionary<string, string>
            {
                {"term", term},
                {"lang", lang},
                {"country", country},
                {"limit", limit.ToString()}
            };

            return BaseUrl + "?" + string.Join("&", param.Select(item => $"{item.Key}={item.Value}"));
        }

        private static string GetMockResponse()
        {
            var assembly = typeof(ApiClient).GetTypeInfo().Assembly;
            var stream = assembly.GetManifestResourceStream("Alexandros.SearchMockResponse.json");
            string text;
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            return text;
        }

        internal static async Task<Response> Search(string term, string lang, string country, int limit)
        {
#if MOCK
            var response = GetMockResponse();
#else
            var response = await HttpClient.GetStringAsync(GetSearchUrl(term, lang, country, limit));
#endif

            return string.IsNullOrWhiteSpace(response) ? null : JsonConvert.DeserializeObject<Response>(response);
        }
    }
}