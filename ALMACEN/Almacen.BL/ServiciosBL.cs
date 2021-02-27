using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.BL
{
    public class ServiciosBL
    {
        Contexto _contexto;
        public List<Servicio> ListadeServicios { get; set; }

        public ServiciosBL()
        {
            _contexto = new Contexto();
            ListadeServicios = new List<Servicio>();
        }

        public List<Servicio> ObtenerServicios()
        {
            ListadeServicios = _contexto.Servicios.Include("Categoria").ToList();

            return ListadeServicios;
        }

//Segunda Entrega
//------------------------------------------------------------------------------

        public void GuardarServicio(Servicio servicio)
        {

            if(servicio.Id == 0)
            {
                _contexto.Servicios.Add(servicio);
            }
            else
            {
                var servicioExistente = _contexto.Servicios.Find(servicio.Id);
                servicioExistente.Descripcion = servicio.Descripcion;
                servicioExistente.Precio = servicio.Precio;
                servicioExistente.Activo = servicio.Activo;

            }

            _contexto.SaveChanges();
        }

        public Servicio ObtenerServicio(int id)
        {
            var servicio = _contexto.Servicios.Find(id);

            return servicio;
        }

        public void EliminarServicio(int Id)
        {
            var servicio = _contexto.Servicios.Find(Id);

            _contexto.Servicios.Remove(servicio);

            _contexto.SaveChanges();
            
        }

    }
}
