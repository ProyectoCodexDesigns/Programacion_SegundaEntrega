using System;
using Proyecto_SISVIANZA_v1.Persistencia;
namespace Proyecto_SISVIANZA_v1.Logica
{
    class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int CantidadMenus { get; set; }
        public int CantidadVehiculos { get; set; }
        public string Descripcion { get; set; }
        public string TipoMenu { get; set; }
        public int CantidadViandas { get; set; }
        public string PreferenciasDieteticas { get; set; }
        public DateTime FechaEntrega { get; set; } // Corrección aquí
        public string Direccion { get; set; }
        public string Estado { get; set; }

        public Pedido(int id, Cliente cliente, int cantidad_Menus, int cantidad_Vehiculos, string descripcion, string tipoMenu, int cantidadViandas, string preferenciasDieteticas, DateTime fechaEntrega, string direccion, string estado)
        {
            Id = id;
            Cliente = cliente;
            CantidadMenus = cantidad_Menus;
            CantidadVehiculos = cantidad_Vehiculos;
            Descripcion = descripcion;
            TipoMenu = tipoMenu;
            CantidadViandas = cantidadViandas;
            PreferenciasDieteticas = preferenciasDieteticas;
            FechaEntrega = fechaEntrega;
            Direccion = direccion;
            Estado = estado;


        }

    }
}
