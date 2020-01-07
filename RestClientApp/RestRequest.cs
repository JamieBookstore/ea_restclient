using Newtonsoft.Json;
using RestClient.Dto;
using RestClientApp.Dto;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace RestClient
{
    public class RestRequest
    {
        private static readonly HttpClient client = new HttpClient();

        public async Task<IList<EventDto>> GetEvents(string server)
        {
            var stringTask = await client.GetStringAsync(server);
            return JsonConvert.DeserializeObject<List<EventDto>>(stringTask);
        }

        public async Task<EventDetailDto> GetEvent(string server)
        {
            var stringTask = await client.GetStringAsync(server);
            return JsonConvert.DeserializeObject<EventDetailDto>(stringTask);
        }

        public async Task<EventAdmissionsDto> GetEventAdmissions(string server)
        {
            var stringTask = await client.GetStringAsync(server);
            return JsonConvert.DeserializeObject<EventAdmissionsDto>(stringTask);
        }

    }
}
