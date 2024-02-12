using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using H3OpgaveETL1.Client.Code;

namespace H3OpgaveETL1.Client.Code
{
    public class Extract
    {
        public async Task<string> GetDataAsJsonAsync(string url)
        {
            HttpClient httpClient = new HttpClient();
            string json = await httpClient.GetStringAsync(url);
            return json;
        }
    }
}
