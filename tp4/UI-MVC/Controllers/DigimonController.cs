using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI_MVC.Controllers
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Threading.Tasks;
    using System.Web;
    using System.Web.Mvc;
    using UI_MVC.Models;

    namespace WebApplication1.Controllers
    {
        public class DigimonController : Controller
        {
            // GET: Api
            string baseUrl = "https://digimon-api.herokuapp.com";
            public async Task<ActionResult> Index()
            {
                var digimons = new List<DigimonViewModel>();

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();

                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage responseMessage = await client.GetAsync("/api/digimon");

                    if (responseMessage.IsSuccessStatusCode)
                    {
                        var digimonResponse = responseMessage.Content.ReadAsStringAsync().Result;

                        digimons = JsonConvert.DeserializeObject<List<DigimonViewModel>>(digimonResponse);
                    }
                }

                return View(digimons);
            }
        }
    }
}