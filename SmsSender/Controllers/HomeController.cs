using SmsSender.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmsSender.Controllers
{
    public class HomeController : Controller
    {
        private List<Unidad> unidades = new List<Unidad>();

        // GET: Home
        public ActionResult Index()
        {
            if(unidades.Count == 0)
                obtenerUnidades();

            return View(unidades);
        }

        [HttpPost]
        public ActionResult SubmitSelected(List<Unidad> model)
        {
            var selectedIds = model.Where(m => m.EsSeleccionado);

            return RedirectToAction("Index");
        }

        private void obtenerUnidades()
        {
            unidades.Add(new Unidad { Empresa = "FEMSA", Marca = "Mercedes Benz", NumeroSerie = "134893849", Telefono = "2414142397" });
            unidades.Add(new Unidad { Empresa = "JUMEX", Marca = "Mercedes Benz", NumeroSerie = "948284851", Telefono = "2223789777" });
        }
    }
}
