using Proyecto_SISVIANZA_v1.Persistencia;

namespace Proyecto_SISVIANZA_v1.Logica
{
    class Ingreso
    {
        private IngresoPersistencia ingresoPersistencia;

        public Ingreso()
        {
            ingresoPersistencia = new IngresoPersistencia();
        }

        public bool Verificar(string nombre, string contraseña)
        {
            return ingresoPersistencia.Verificar(nombre, contraseña);
        }

        public string ObtenerRol(string nombre)
        {
            return ingresoPersistencia.ObtenerRol(nombre);
        }
    }
}