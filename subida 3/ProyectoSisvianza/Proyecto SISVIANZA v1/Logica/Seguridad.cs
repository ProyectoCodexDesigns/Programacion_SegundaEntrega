using Proyecto_SISVIANZA_v1.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_SISVIANZA_v1.Logica
{
    internal class Seguridad
    {
        private SeguridadPersistencia seguridadPersistencia;
        public Seguridad() => seguridadPersistencia = new SeguridadPersistencia();
        public void RealizarCopiaSeguridad(string backupPath) => seguridadPersistencia.RealizarCopiaSeguridad(backupPath);
    }
}
