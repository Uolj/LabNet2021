using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UI_MVC.Controllers
{
    using APILogic;
    using Entities;
    using Logic;
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
            DigimonLogic logic = new DigimonLogic();

            public async Task<ActionResult> Index()
            {
                List<Digimon> digimons = await logic.Get();
                List<DigimonViewModel> digimonsViewModel = digimons.Select(d => new DigimonViewModel()
                {
                    Name = d.Name,
                    Level = d.Level,
                    Img = d.Img
                }).ToList();

                return View(digimonsViewModel);
            }

        }
    }
}