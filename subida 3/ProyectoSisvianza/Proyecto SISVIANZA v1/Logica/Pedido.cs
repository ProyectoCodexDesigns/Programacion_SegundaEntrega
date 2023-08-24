using MySqlX.XDevAPI;
using System;
namespace Proyecto_SISVIANZA_v1.Logica
{
    class Pedido
    {
        public int Id { get; set; }
        public Cliente Cliente { get; set; }
        public int CantidadMenus { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; }
        public int Estado { get; set; }
        public int Tipo_Menu { get; set; } 
        public int Cantidad_VIandas { get; set; }

        public Pedido(int id, int cantidad_Menus, string descripcion, DateTime fechaEntrega,DateTime fechaCreacion,Cliente cliente, int estado,int tipo_menu,int cantidad_viandas)
        {
            Id = id;
            Cliente = cliente;
            CantidadMenus = cantidad_Menus;
            Descripcion = descripcion;
            FechaEntrega = fechaEntrega;
            FechaCreacion = fechaCreacion;
            Estado = estado;
            Tipo_Menu = tipo_menu;
            Cantidad_VIandas = cantidad_viandas;
        }

    }
}
