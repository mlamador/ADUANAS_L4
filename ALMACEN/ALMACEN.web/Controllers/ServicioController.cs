using ALMACEN.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ALMACEN.web.Controllers
{
    public class ServicioController : Controller
    {
        // GET: Servicio
        public ActionResult Index()
        {
            var servicio1 = new ServicioModel();
            servicio1.Id = 1;
            servicio1.Descripcion = "Almacenamiento General";

            var servicio2 = new ServicioModel();
            servicio2.Id = 2;
            servicio2.Descripcion = "Almacenamiento Temporal";

            var servicio3 = new ServicioModel();
            servicio3.Id = 3;
            servicio3.Descripcion = "Almacenamiento Transito";

            var servicio4 = new ServicioModel();
            servicio4.Id = 4;
            servicio4.Descripcion = "Carga y Descarga de Mercaderia";

            var listaServicios = new List<ServicioModel>();
            listaServicios.Add(servicio1);
            listaServicios.Add(servicio2);
            listaServicios.Add(servicio3);
            listaServicios.Add(servicio4);


            return View(listaServicios);
        }
    }
}