using System.Text.Json;
using System.Net.Http.Headers;

namespace SVT_Robotics_Recruiting_Assessment
{
    public static class CurrentRobotStatusAPI
    {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string uri = "https://60c8ed887dafc90017ffbd56.mockapi.io/robots";

        public static async Task<List<Robot>> GetRobots()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var streamTask = client.GetStreamAsync(uri);

            List<Robot>? robots = await JsonSerializer.DeserializeAsync<List<Robot>>(await streamTask);

            if (robots == null)
                robots = new List<Robot>();

            return robots;
        }
    }
}
