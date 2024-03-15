using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyCelebrityApplication.DataManager
{
    internal class CelebrityDataManager
    {
        public static async Task<List<Models.Celebrity>> GetCelebrity(string uri)
        {
            List<Models.Celebrity> celebrities = null;

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://api.api-ninjas.com/v1/");
            client.DefaultRequestHeaders.Add("X-Api-Key", "ieOcxyo8lTslmkUkOyfkaw==5r43225X6mgqgOen");

            HttpResponseMessage response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                string responseString = await response.Content.ReadAsStringAsync();
                celebrities = JsonSerializer.Deserialize<List<Models.Celebrity>>(responseString);
            }

            for (int i = 0; i < celebrities.Count; i++)
            {
                for (int j = 0; j < celebrities[i].occupation.Length; j++)
                {
                    celebrities[i].occupation[0] += celebrities[i].occupation[j] + ", ";
                }
                if (celebrities[i].occupation.Length > 1)
                {
                    celebrities[i].occupation[0] = celebrities[i].occupation[0].Substring(0, celebrities[i].occupation[0].Length - 2);
                }
                //else
                //{
                //    celebrities[i].occupation[0] = celebrities[i].occupation[0].Substring(0, celebrities[i].occupation[0].Length - 1);
                //}
            }
            return celebrities;
        }
    }
}
