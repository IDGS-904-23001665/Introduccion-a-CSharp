using IntroduccionCSharp.Models;
using IntroduccionCSharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IntroduccionCSharp.Controllers
{
    public class PruebaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suma(String x, String y, String r1)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }

        public ActionResult Calculos(OperasBas ap)
        {
            ap.Suma();
            return View(ap);
        }

        public ActionResult MuestraPeliculas()
        {
            var PeliculaService = new PeliculaService();
            var model = PeliculaService.ObtenerPelicula();
            return View(model);
        }
    }
}