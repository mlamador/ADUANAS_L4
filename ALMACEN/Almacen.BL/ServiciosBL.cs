using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.BL
{
    public class ServiciosBL
    {
        public List<Servicio> ObtenerServicios()
        {
            var servicio1 = new Servicio();
            servicio1.Id = 1;
            servicio1.Descripcion = "Almacenamiento General";

            var servicio2 = new Servicio();
            servicio2.Id = 2;
            servicio2.Descripcion = "Almacenamiento Temporal";

            var servicio3 = new Servicio();
            servicio3.Id = 3;
            servicio3.Descripcion = "Almacenamiento Transito";

            var servicio4 = new Servicio();
            servicio4.Id = 4;
            servicio4.Descripcion = "Carga y Descarga de Mercaderia";

            var listaServicios = new List<Servicio>();
            listaServicios.Add(servicio1);
            listaServicios.Add(servicio2);
            listaServicios.Add(servicio3);
            listaServicios.Add(servicio4);

            return listaServicios;
        }

    }
}
