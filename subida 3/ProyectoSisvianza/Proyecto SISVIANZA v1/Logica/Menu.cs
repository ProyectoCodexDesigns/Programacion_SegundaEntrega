using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_SISVIANZA_v1.Logica
{
    class Menu
    {

        public int Id { get; set; }
        public int Stock { get; set; }
        public string Nombre { get; set; }
        public int StockMinimo { get; set; }


        public Menu(int id, int stock, string nombre, int stockMinimo)
        {
            Id = id;
            Stock = stock;
            Nombre = nombre;
            StockMinimo = stockMinimo;
        }
    }
}
