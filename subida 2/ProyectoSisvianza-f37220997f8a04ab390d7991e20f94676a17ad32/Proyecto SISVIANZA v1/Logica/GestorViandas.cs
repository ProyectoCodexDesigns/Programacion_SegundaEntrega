using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_SISVIANZA_v1.Persistencia;

namespace Proyecto_SISVIANZA_v1.Logica
{
    class GestorViandas
    {
        private ViandasPersistencia viandasPersistencia;

        public GestorViandas()
        {
            viandasPersistencia = new ViandasPersistencia();
        }

        public List<Vianda> ObtenerTodasLasViandas()
        {
            return viandasPersistencia.ObtenerTodasLasViandas();
        }
        public List<Vianda> ObtenerViandasPorId(int id)
        {
            return viandasPersistencia.ObtenerViandasPorId(id);
        }
    }
}
