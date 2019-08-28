using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SmartiksProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartiksProje.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
         
            return View();
        }
        [HttpPost]
        public ActionResult Index(Mapping map)
        {
            Mapping mappAdresi = new Mapping();
            mappAdresi.id = map.id;
            mappAdresi.kazaAciklama = map.kazaAciklama;
            mappAdresi.kazaTarihi = map.kazaTarihi;
            mappAdresi.kazasaati = map.kazasaati;

            return View(mappAdresi);
        }
    }
}