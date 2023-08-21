using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_SISVIANZA_v1.Logica
{
    class Vianda
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string TipoDieta { get; set; }
        public int TiempoHoras { get; set; }
        public string Descripcion { get; set; }
        public string TipoPostre { get; set; }


        public Vianda(int id, string nombre, DateTime fechaCaducidad, string tipoDieta, int tiempoHoras, string descripcion, string tipoPostre)
        {
            Id = id;
            Nombre = nombre;
            FechaCaducidad = fechaCaducidad;
            TipoDieta = tipoDieta;
            TiempoHoras = tiempoHoras;
            Descripcion = descripcion;
            TipoPostre = tipoPostre;
        }

    }
}
