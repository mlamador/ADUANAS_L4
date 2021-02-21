using Almacen.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALMACEN.WebAdmin.Controllers
{
//Segunda Entrega
//--------------------------------------------------------------------------------

    public class ServiciosController : Controller
    {
        ServiciosBL _serviciosBL;

        public ServiciosController()
        {
            _serviciosBL = new ServiciosBL();
        }

        // GET: Servicios
        public ActionResult Index()
        {
            var listadeServicios = _serviciosBL.ObtenerServicios();

            return View(listadeServicios);
        }

        public ActionResult Crear()
        {
            var nuevoServicio = new Servicio();

            return View(nuevoServicio);
        }

        [HttpPost]

        public ActionResult Crear(Servicio servicio)
        {
          //  _serviciosBL.GuardarServicio(servicio);

            return RedirectToAction("Index");
        }

        public ActionResult Editar(int id)
        {
           var servicio = _serviciosBL.ObtenerServicio(id);

            return View(servicio);
        }

        [HttpPost]

        public ActionResult Editar(Servicio servicio)
        {
            _serviciosBL.GuardarServicio(servicio);

            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var servicio = _serviciosBL.ObtenerServicio(id);

            return View(servicio);
        }

        public ActionResult Eliminar(int id)
        {
            var servicio = _serviciosBL.ObtenerServicio(id);

            return View(servicio);
        }

        [HttpPost]

        public ActionResult Eliminar(Servicio servicio)
        {

            _serviciosBL.EliminarServicio(servicio.Id);

            return RedirectToAction("Index");
        }

    }
}