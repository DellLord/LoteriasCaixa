using System.Net.Http;
using System.Threading.Tasks;

namespace LoteriasCaixa.Common
{
    public static class CustomHttpClient
    {
        public static async Task<string> DocumentText(string uri)
        {
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                return (await response.Content.ReadAsStringAsync());
            }
        }
    }
}
