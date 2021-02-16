using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Almacen.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("ALMACENDB") 
        {
                            

        }
        public DbSet<Servicio> Servicios { get; set; }
    }
}
