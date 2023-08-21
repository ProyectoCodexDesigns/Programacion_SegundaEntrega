using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto_SISVIANZA_v1.Persistencia;

namespace Proyecto_SISVIANZA_v1.Logica
{
    class GestorMenu
    {
        private MenuPersistencia menuPersistencia;

        public GestorMenu()
        {
            menuPersistencia = new MenuPersistencia();
        }
        public List<Menu> ObtenerTodosLosMenu()
        {
        
            return menuPersistencia.ObtenerTodosLosMenus();
        }

        public List<Menu> ObtenerMenusPorId(int id)
        {
            return menuPersistencia.ObtenerMenusPorId(id);
        }
    }
}
