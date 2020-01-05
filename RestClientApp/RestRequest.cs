using Newtonsoft.Json;
using RestClient.Dto;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestClient
{
    class RestRequest
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IList<EventDto>> GetEvents(string host)
        {
            var stringTask = await client.GetStringAsync(host);
            return JsonConvert.DeserializeObject<List<EventDto>>(stringTask);
        }
    }
}
