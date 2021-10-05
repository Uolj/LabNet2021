using Entities;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace APILogic
{
    public class DigimonLogic
    {
        public async Task<List<Digimon>> Get()
        {
            var client = new HttpClient();
            var json = await client.GetStringAsync($"https://digimon-api.herokuapp.com/api/digimon");

            dynamic digimons = JsonConvert.DeserializeObject<List<Digimon>>(json);
            return digimons;
        }
    }
}
